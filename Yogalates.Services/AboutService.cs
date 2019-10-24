using System.Collections.Generic;
using AutoMapper;
using Yogalates.Common.ViewModels;
using Yogalates.Data.Data;
using Yogalates.Services.Contracts;

namespace Yogalates.Services
{
    public class AboutService :BaseService, IAboutService
    {
        public AboutService(YogalatesDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public IEnumerable<ServiceViewModel> GetAll()
        {
            var allServices = Mapper.Map<IEnumerable<ServiceViewModel>>(
                DbContext.Services);

            return allServices;
        }
    }
}
