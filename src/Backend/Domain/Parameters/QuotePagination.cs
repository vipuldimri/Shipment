using Domain.Entities;
using System.Collections.Generic;
namespace Domain.Parameters
{
    public class QuotePagination
    {
        public int count { get; set; }
        public int totalCount { get; set; }
        public int page { get; set; }
        public int totalPages { get; set; }
        public object lastItemIndex { get; set; }
        public List<Quote> results { get; set; }
    }
}
