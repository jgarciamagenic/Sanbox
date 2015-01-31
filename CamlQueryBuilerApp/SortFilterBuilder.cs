namespace CamlQueryBuilderApp
{
    using System;
    using System.Collections.Generic;

    public static class SortFilterBuilder
    {

        public static SortFilter OneFilter()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");

            sortFilter.Filters.Add(f1);

            return sortFilter;
        }

        public static SortFilter TwoFilters()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");

            sortFilter.Filters.Add(f1);

            var f2 = new FilterSelection { Name = "Status", Field = "RequestStatus", DataType = "Text" };
            f2.Values.Add("0");
            f2.Values.Add("1");

            sortFilter.Filters.Add(f2);

            return sortFilter;
        }


        public static SortFilter ThreeFilters()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");

            sortFilter.Filters.Add(f1);

            var f2 = new FilterSelection { Name = "Status", Field = "RequestStatus", DataType = "Text" };
            f2.Values.Add("0");
            f2.Values.Add("1");

            sortFilter.Filters.Add(f2);

            var f3 = new FilterSelection { Name = "Client Type", Field = "ClientTypeId", DataType = "Text" };
            f3.Values.Add("0");

            sortFilter.Filters.Add(f3);

            return sortFilter;
        }

        public static SortFilter FourFilters()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");

            sortFilter.Filters.Add(f1);

            var f2 = new FilterSelection { Name = "Status", Field = "RequestStatus", DataType = "Text" };
            f2.Values.Add("0");
            f2.Values.Add("1");

            sortFilter.Filters.Add(f2);

            var f3 = new FilterSelection { Name = "Client Type", Field = "ClientTypeId", DataType = "Text" };
            f3.Values.Add("0");

            sortFilter.Filters.Add(f3);

            var f4 = new FilterSelection { Name = "Primary Member Firm", Field = "PrimaryMemberFirmId", DataType = "Text" };
            f4.Values.Add("3");

            sortFilter.Filters.Add(f4);

            return sortFilter;
        }


        public static SortFilter FiveFilters()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");

            sortFilter.Filters.Add(f1);

            var f2 = new FilterSelection { Name = "Status", Field = "RequestStatus", DataType = "Text" };
            f2.Values.Add("0");
            f2.Values.Add("1");

            sortFilter.Filters.Add(f2);

            var f3 = new FilterSelection { Name = "Client Type", Field = "ClientTypeId", DataType = "Text" };
            f3.Values.Add("0");

            sortFilter.Filters.Add(f3);

            var f4 = new FilterSelection { Name = "Primary Member Firm", Field = "PrimaryMemberFirmId", DataType = "Text" };
            f4.Values.Add("3");

            sortFilter.Filters.Add(f4);

            var f5 = new FilterSelection { Name = "Sponsoring Tax Partner Or Director", Field = "SponsoringTaxPartnerOrDirector", DataType = "Text" };
            f5.Values.Add("Task16550");

            sortFilter.Filters.Add(f5);

            return sortFilter;
        }

        public static SortFilter FiveFiltersSingular()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");

            sortFilter.Filters.Add(f1);

            var f2 = new FilterSelection { Name = "Status", Field = "RequestStatus", DataType = "Text" };
            f2.Values.Add("1");

            sortFilter.Filters.Add(f2);

            var f3 = new FilterSelection { Name = "Client Type", Field = "ClientTypeId", DataType = "Text" };
            f3.Values.Add("0");

            sortFilter.Filters.Add(f3);

            var f4 = new FilterSelection { Name = "Primary Member Firm", Field = "PrimaryMemberFirmId", DataType = "Text" };
            f4.Values.Add("3");

            sortFilter.Filters.Add(f4);

            var f5 = new FilterSelection { Name = "Sponsoring Tax Partner Or Director", Field = "SponsoringTaxPartnerOrDirector", DataType = "Text" };
            f5.Values.Add("Task16550");

            sortFilter.Filters.Add(f5);

            return sortFilter;
        }

        public static SortFilter FiveFiltersMany()
        {
            var sortFilter = new SortFilter();

            var f1 = new FilterSelection { Name = "Requestor", Field = "Requestor", DataType = "Text" };
            f1.Values.Add("Galileo Galilei");
            f1.Values.Add("Josh Garcia");

            sortFilter.Filters.Add(f1);

            var f2 = new FilterSelection { Name = "Status", Field = "RequestStatus", DataType = "Text" };
            f2.Values.Add("0");
            f2.Values.Add("1");

            sortFilter.Filters.Add(f2);

            var f3 = new FilterSelection { Name = "Client Type", Field = "ClientTypeId", DataType = "Text" };
            f3.Values.Add("0");
            f3.Values.Add("1");
            f3.Values.Add("2");

            sortFilter.Filters.Add(f3);

            var f4 = new FilterSelection { Name = "Primary Member Firm", Field = "PrimaryMemberFirmId", DataType = "Text" };
            f4.Values.Add("0");
            f4.Values.Add("1");
            f4.Values.Add("2");
            f4.Values.Add("3");

            sortFilter.Filters.Add(f4);

            var f5 = new FilterSelection { Name = "Sponsoring Tax Partner Or Director", Field = "SponsoringTaxPartnerOrDirector", DataType = "Text" };
            f5.Values.Add("Task16550");
            f5.Values.Add("JoshG");
            f5.Values.Add("Josh Garcia");
            f5.Values.Add("Josue Garcia");

            sortFilter.Filters.Add(f5);

            return sortFilter;
        }
    }
}
