using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcOnIkiSubat.Helpers
{
    public class WriteTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent("Merhaba");

            base.Process(context, output);
        }
    }
}
