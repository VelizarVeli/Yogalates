using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Yogalates.Common.Constants;

namespace Yogalates.Models
{
    public class Article : BaseId
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
        }

        [Required]
        [StringLength(LengthConstants.MaxLength, MinimumLength = LengthConstants.MinLength)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Image800X533 { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.UtcNow;

        public ICollection<Comment> Comments { get; set; }
    }
}
