using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcOnIkiSubat.Helpers
{
    public class GoogleTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "https://www.google.com");
            base.Process(context, output);
        }
    }
}
