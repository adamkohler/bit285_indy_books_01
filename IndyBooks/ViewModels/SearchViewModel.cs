using System;
namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public string Title { get; set; }

        //TODO: Add properties needed for searching
        public string LastName { get; set; }
        public decimal minPrice { get; set; }
        public decimal maxPrice { get; set; }
    }
}
