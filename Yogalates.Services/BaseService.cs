using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Yogalates.Data.Data;
using Yogalates.Models;

namespace Yogalates.Services
{
   public abstract class BaseService
    {
        protected BaseService(YogalatesDbContext dbContext,
            IMapper mapper
            /* UserManager<YogalatesUser> userManager*/)
        {
            DbContext = dbContext;
            Mapper = mapper;
            //userManager = UserManager;
        }

        protected YogalatesDbContext DbContext { get; }

        protected IMapper Mapper { get; }

        protected UserManager<YogalatesUser> UserManager { get; set; }

        //protected async Task<YogalatesUser> GetUserByIdAsync(string id)
        //{
        //    var user = await this.UserManager.FindByIdAsync(id);

        //    return user;
        //}
    }
}
