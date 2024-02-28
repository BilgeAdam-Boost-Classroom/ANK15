using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcOnIkiSubat.Helpers
{
    public class KontrolTagHelper : TagHelper
    {
        public int Number { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Number % 2 == 0)
            {
                output.Content.SetContent($"{Number} ciftir");
            }
            else
            {
                output.Content.SetContent($"{Number} Tektir");
            }
        }
    }
}
