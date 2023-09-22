using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BasicApp.Web.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }

        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }

        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }

        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new ();
            stringBuilder.Append("<ul class='pagination'>");
            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat($"<li class='{(i == CurrentPage ? "active" : string.Empty)}'>");
                stringBuilder.AppendFormat($"<a href='/product/index?page={i}&category={CurrentCategory}'>{i}</a>");
                stringBuilder.Append("</li>");
            }
            stringBuilder.Append("</ul>");
            output.Content.AppendHtml(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}
