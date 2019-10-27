using System;

namespace Yogalates.Common.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Image800X533 { get; set; }

        public string Name { get; set; }
        
        public string Content { get; set; }
    }
}
