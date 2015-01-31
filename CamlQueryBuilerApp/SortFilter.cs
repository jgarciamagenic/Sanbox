namespace CamlQueryBuilderApp
{
    using System.Collections.Generic;

    public class SortFilter
    {
        public SortFilter()
        {
            this.SortBy = new DtiSelectListItem();
            this.SortReverse = false;
            this.Filters = new List<FilterSelection>();
        }

        public DtiSelectListItem SortBy { get; set; }
        public bool SortReverse { get; set; }
        public List<FilterSelection> Filters { get; set; }

        public int PageSize { get; set; }
        public int PagePosition { get; set; }

        public string SP_PagePosition { get; set; }
        public int TotalRetrieved { get; set; }
    }
}
