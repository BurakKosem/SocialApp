using Application.Core;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images
{
    public class Delete
    {
        public class Command : IRequest<Result<Unit>>
        {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;
            private readonly IImageAccessor _imageAccessor;

            public Handler(DataContext context, IUserAccessor userAccessor, IImageAccessor imageAccessor)
            {
                _context = context;
                _userAccessor = userAccessor;
                _imageAccessor = imageAccessor;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.Include(i => i.Images)
                    .FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetUsername());

                if (user == null) return null;

                var image = user.Images.FirstOrDefault(x => x.Id == request.Id);

                if (image == null) return null;

                if (image.IsMain) return Result<Unit>.Failure("You cannot your main image");

                var result = await _imageAccessor.DeleteImage(image.Id);

                if (result == null) return Result<Unit>.Failure("Problem deleting image from Cloud");

                user.Images.Remove(image);

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Result<Unit>.Success(Unit.Value);

                return Result<Unit>.Failure("Problem deleting image from API");

            }
        }
    }
}
