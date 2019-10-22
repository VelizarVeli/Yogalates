using AutoMapper;
using Yogalates.Common.ViewModels;
using Yogalates.Models;

namespace Yogalates.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ConfigureArticles();
        }

        private void ConfigureArticles()
        {
            CreateMap<Article, ArticleViewModel>();
        }
    }
}
