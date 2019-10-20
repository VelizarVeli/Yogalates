using System;
namespace Yogalates.Common.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        public string CommenterName { get; set; }

        public string Content { get; set; }

        public DateTime CommentDate { get; set; } 
    }
}
