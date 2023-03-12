using System.Collections.Generic;

namespace Domain.Entities
{
    public class Quote
    {
        public string _id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public List<string> Tags { get; set; }
        public string AuthorSlug { get; set; }
        public int Length { get; set; }
        public string DateAdded { get; set; }
        public string DateModified { get; set; }
    }
}
