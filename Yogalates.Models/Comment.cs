using System;
using System.ComponentModel.DataAnnotations;
using Yogalates.Common.Constants;

namespace Yogalates.Models
{
    public class Comment : BaseId
    {
        [Required]
        [StringLength(LengthConstants.MaxLength, MinimumLength = LengthConstants.MinLength)]
        public string CommenterName { get; set; }

        [Required]
        [StringLength(LengthConstants.CommentMaxLength, MinimumLength = LengthConstants.MinLength)]
        public string Content { get; set; }

        [Required]
        public DateTime CommentDate { get; set; } = DateTime.UtcNow;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
