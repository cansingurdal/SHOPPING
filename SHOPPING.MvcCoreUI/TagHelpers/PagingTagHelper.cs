using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SHOPPING.MvcCoreUI.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int pageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int pageCount { get; set; }
        [HtmlAttributeName("current-category")]
        public int currentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int currentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='pagination'>");

            for (int i = 1; i <= pageCount; i++)
            {
                stringBuilder.AppendFormat("<li class='{0}'>", i == currentPage ? " active" : "");
                stringBuilder.AppendFormat("<a href='/product/index?page={0}&category={1}'>{2}</a>",
                    i, currentCategory, i);
                stringBuilder.Append("</li>");


            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
