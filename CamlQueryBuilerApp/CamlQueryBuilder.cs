namespace CamlQueryBuilderApp
{
    using System.Collections.Generic;
    using System.Text;

    public class CamlQueryBuilder
    {
        public enum ConditionOperators { And, Or }

        private readonly ConditionOperators ConditionOperator;

        public CamlQueryBuilder(ConditionOperators conditionOperator)
        {
            this.ConditionOperator = conditionOperator;
        }

        public string Build(SortFilter sortFilter)
        {
            return this.BuildWhereCondition(sortFilter);
        }

        private string BuildWhereCondition(SortFilter sortFilter)
        {
            var whereCondition = new StringBuilder();

            whereCondition.Append("<Where>");

            var comparisons = this.BuildComparisons(sortFilter);

            if (comparisons.Count == 1)
            {
                whereCondition.Append(comparisons[0]);
            }
            else
            {
                var conditions = this.BuildConditions(comparisons);
                whereCondition.Append(conditions);
            }

            whereCondition.Append("</Where>");

            return whereCondition.ToString();
        }

        private string BuildConditions(List<string> comparisons)
        {
            var conditionBuffer = new StringBuilder();

            var comparisonGroups = this.BuildComparisonGroups(comparisons);
                        
            var counter = 0;

            foreach (var comparisonGroup in comparisonGroups)
            {
                counter++;

                if (comparisonGroup.Count == 1)
                {
                    if (counter > 1)
                    {
                        var group = new StringBuilder();

                        group.Append(string.Concat("<", ConditionOperator.ToString(), ">"));

                        group.Append(conditionBuffer.ToString());

                        group.Append(comparisonGroup[0]);

                        group.Append(string.Concat("</", ConditionOperator.ToString(), ">"));

                        conditionBuffer.Clear();

                        conditionBuffer.Append(group.ToString());
                    }
                }
                else
                {
                    if (counter == 1)
                    {
                        var group = new StringBuilder();

                        group.Append(string.Concat("<", ConditionOperator.ToString(), ">"));

                        foreach (var comparison in comparisonGroup)
                        {
                            group.Append(comparison);
                        }

                        group.Append(string.Concat("</", ConditionOperator.ToString(), ">"));

                        conditionBuffer.Append(group.ToString());
                    }
                    else
                    {
                        var group = new StringBuilder();

                        group.Append(string.Concat("<", ConditionOperator.ToString(), ">"));

                        group.Append(conditionBuffer.ToString());


                        group.Append(string.Concat("<", ConditionOperator.ToString(), ">"));
                        foreach (var comparison in comparisonGroup)
                        {
                            group.Append(comparison);
                        }
                        group.Append(string.Concat("</", ConditionOperator.ToString(), ">"));


                        group.Append(string.Concat("</", ConditionOperator.ToString(), ">"));

                        conditionBuffer.Clear();

                        conditionBuffer.Append(group.ToString());
                    }
                }
            }

            return conditionBuffer.ToString();
        }

        private List<List<string>> BuildComparisonGroups(List<string> comparisons)
        {
            var returnList = new List<List<string>>();

            var groupBuffer = new List<string>();

            var counter = 0;
            
            foreach (var comparison in comparisons)
            {
                counter++;

                if (counter <= 2)
                {
                    groupBuffer.Add(comparison);
                }
                else
                {
                    var groupList = new List<string>();

                    foreach (var group in groupBuffer)
                    {
                        groupList.Add(group);
                    }

                    returnList.Add(groupList);

                    groupBuffer.Clear();

                    groupBuffer.Add(comparison);

                    counter = 1;
                }
            }

            returnList.Add(groupBuffer);
            
            return returnList;
        }

        private List<string> BuildComparisons(SortFilter sortFilter)
        {
            var returnList = new List<string>();

            foreach (var filterSelection in sortFilter.Filters)
            {
                returnList.Add(this.BuildComparison(filterSelection));
            }

            return returnList;
        }

        private string BuildComparison(FilterSelection filterSelection)
        {
            var comparison = new StringBuilder();

            var fieldRef = string.Concat("<FieldRef Name='", filterSelection.Field, "' />");

            if (filterSelection.Values.Count == 1)
            {
                comparison.Append("<Eq>");

                comparison.Append(fieldRef);

                var value = this.BuildValue(filterSelection.DataType, filterSelection.Values[0]);

                comparison.Append(value);

                comparison.Append("</Eq>");
            }
            else if(filterSelection.Values.Count > 1)
            {
                comparison.Append("<In>");

                comparison.Append(fieldRef);

                comparison.Append("<Values>");

                foreach (var selection in filterSelection.Values)
                {
                    var value = this.BuildValue(filterSelection.DataType, selection);

                    comparison.Append(value);
                }

                comparison.Append("</Values>");

                comparison.Append("</In>");
            }

            return comparison.ToString();
        }

        private string BuildValue(string dataType, string value)
        {
            return string.Concat("<Value Type='", dataType, "'>", value, "</Value>");
        }

    }
}
