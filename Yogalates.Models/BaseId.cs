using System.ComponentModel.DataAnnotations;
using Yogalates.Models.Contracts;

namespace Yogalates.Models
{
    public abstract class BaseId : IBaseId<int>
    {
        [Key]
        public int Id { get; set; }
    }
}
