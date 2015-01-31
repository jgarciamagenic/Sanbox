namespace CamlQueryBuilderApp
{
    using System.Collections.Generic;

    public class FilterSelection
    {
        public FilterSelection()
        {
            this.Values = new List<string>();
        }

        public string Name { get; set; }
        public string Field { get; set; }
        public string DataType { get; set; }
        public bool IsLookUp { get; set; }

        public List<string> Values { get; set; }
    }
}
