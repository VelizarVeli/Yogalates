using System.Collections.Generic;
using Yogalates.Common.ViewModels;

namespace Yogalates.Services.Contracts
{
    public interface IAboutService
    {
        IEnumerable<ServiceViewModel> GetAll();
    }
}
