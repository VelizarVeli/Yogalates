using System.Collections.Generic;
using System.Threading.Tasks;
using Yogalates.Common.ViewModels;

namespace Yogalates.Services.Contracts
{
    public interface IBlogService
    {
        Task<IEnumerable<ArticleViewModel>> GetAllArticles();
    }
}
