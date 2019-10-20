using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Yogalates.Common.ViewModels;
using Yogalates.Data.Data;
using Yogalates.Services.Contracts;

namespace Yogalates.Services
{
    public class BlogService : BaseService, IBlogService
    {
        public BlogService(YogalatesDbContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<ArticleViewModel>> GetAllArticles()
        {
            var allArticles = await DbContext.Articles.Select(v => new ArticleViewModel()
            {
                Name = v.Name,
                Id = v.Id,
                Content = v.Content,
                Date = v.Date,
                Image800X533 = v.Image800X533,
                Comments = v.Comments.Select(c => new CommentViewModel
                {
                    CommentDate = c.CommentDate,
                    CommenterName = c.CommenterName,
                    
                }).ToList()

            }).ToListAsync();

            return allArticles;
        }

    }
}
