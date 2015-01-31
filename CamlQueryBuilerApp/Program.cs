using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamlQueryBuilderApp
{
    class Program
    {
        static CamlQueryBuilder camlQueryBuilder = new CamlQueryBuilder(CamlQueryBuilder.ConditionOperators.And);

        static void Main(string[] args)
        {
            //BuildOneFilter();

            //BuildTwoFilters();

            //BuildThreeFilters();

            //BuildFourFilters();

            //BuildFiveFilters();

            //BuildFiveFiltersSingular();

            BuildFiveFiltersMany();
        }

        static void BuildOneFilter()
        {
            var filter = SortFilterBuilder.OneFilter();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }

        static void BuildTwoFilters()
        {
            var filter = SortFilterBuilder.TwoFilters();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }

        static void BuildThreeFilters()
        {
            var filter = SortFilterBuilder.ThreeFilters();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }

        static void BuildFourFilters()
        {
            var filter = SortFilterBuilder.FourFilters();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }

        static void BuildFiveFilters()
        {
            var filter = SortFilterBuilder.FiveFilters();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }

        static void BuildFiveFiltersSingular()
        {
            var filter = SortFilterBuilder.FiveFiltersSingular();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }

        static void BuildFiveFiltersMany()
        {
            var filter = SortFilterBuilder.FiveFiltersMany();

            var whereCondition = camlQueryBuilder.Build(filter);

            Debug.WriteLine(whereCondition);
        }
    }
}
