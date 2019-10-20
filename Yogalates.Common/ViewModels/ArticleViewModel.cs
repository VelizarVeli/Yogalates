using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Yogalates.Common.ViewModels
{
    public class ArticleViewModel
    {
        public ArticleViewModel()
        {
            Comments = new HashSet<CommentViewModel>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Display(Name = "Снимка 800 x 533")]
        public string Image800X533 { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }
        
        [Display(Name = "Съдържание")]
        public string Content { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
