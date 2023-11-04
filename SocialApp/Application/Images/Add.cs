using Application.Core;
using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Images
{
    public class Add
    {
        public class Command : IRequest<Result<Image>>
        {
            public IFormFile File { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Image>>
        {
            private readonly DataContext _context;
            private readonly IImageAccessor _imageAccessor;
            private readonly IUserAccessor _userAccessor;

            public Handler(DataContext context, IImageAccessor imageAccessor, IUserAccessor userAccessor)
            {
                _context = context;
                _imageAccessor = imageAccessor;
                _userAccessor = userAccessor;
            }

            public async Task<Result<Image>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.Include(i => i.Images)
                    .FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetUsername());

                if (user == null) return null;

                var imageUploadResult = await _imageAccessor.AddImage(request.File);

                var image = new Image
                {
                    Url = imageUploadResult.Url,
                    Id = imageUploadResult.PublicId
                };

                if (!user.Images.Any(x => x.IsMain)) image.IsMain = true;

                user.Images.Add(image);

                var result = await _context.SaveChangesAsync() > 0;

                if(result) return Result<Image>.Success(image);

                return Result<Image>.Failure("An problem occured at adding image");

            }
        }
    }
}
