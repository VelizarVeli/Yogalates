using System.ComponentModel.DataAnnotations;
using Yogalates.Common.Constants;

namespace Yogalates.Models
{
    public class Service : BaseId
    {
        [Required]
        [StringLength(LengthConstants.MaxLength, MinimumLength = LengthConstants.MinLength)]
        public string Name { get; set; }

        [Required]
        public string About { get; set; }

        [Required]
        public string Image600X656 { get; set; }
    }
}
