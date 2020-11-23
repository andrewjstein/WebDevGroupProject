using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderTracker.ViewModels
{
    public enum SortOrder
    {
        ASC, DESC
    }
    public class QueryOptions
    {
        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }
        public QueryOptions()
        {
            SortField = "";
            SortOrder = SortOrder.ASC;
        }
        public string Sort => $"{SortField} {SortOrder}";
    }
}