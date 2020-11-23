using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WebDevGroupProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class SortableLinkTagHelper : AnchorTagHelper
    {
        public SortableLinkTagHelper(IHtmlGenerator generator)
            : base(generator)
        {

        }

        public QueryOptions QueryOptions { get; set; }
        public string SortField { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var isCurrentSortField = QueryOptions.SortField == SortField;
            var newSortOrder = isCurrentSortField && (QueryOptions.SortOrder == SortOrder.ASC) ?
                SortOrder.DESC : SortOrder.ASC;
            var newContent = $"{output.PreContent.GetContent()} {BuildSortIcon(isCurrentSortField, QueryOptions)}";
            RouteValues.Add("SortField", SortField);
            RouteValues.Add("SortOrder", newSortOrder.ToString());
            base.Process(context, output);
            output.TagName = "a";
            output.PostContent.SetHtmlContent(newContent);
        }
        private string BuildSortIcon(bool isCurrentSortField, QueryOptions queryOptions)
        {
            string sortDir = "";
            if (isCurrentSortField)
            {
                sortDir = (queryOptions.SortOrder == SortOrder.ASC) ? "-up" : "-down";
            }
            return $"<span class=\"fas fa-sort{sortDir}\"></span>";
        }
    }
}
