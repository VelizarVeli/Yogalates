using System.ComponentModel.DataAnnotations;

namespace Yogalates.Models.Contracts
{
    interface IBaseId<T>
    {
        [Key]
        T Id { get; set; }
    }
}
