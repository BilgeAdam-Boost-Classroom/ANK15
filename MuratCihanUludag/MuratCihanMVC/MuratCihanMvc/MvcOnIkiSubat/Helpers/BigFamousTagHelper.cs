using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcOnIkiSubat.Helpers
{
    public class BigFamousTagHelper : TagHelper
    {
        public string Text { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsBigFamous(Text))
            {
                output.Content.SetContent($"{Text} = Buyuk unlu uyumuna uyar");
            }
            else
            {
                output.Content.SetContent($"{Text} = Buyuk unlu uyumuna uymaz");

            }
        }
        private bool IsBigFamous(string text)
        {
            char[] buyukUnluHarflerKalin = { 'A', 'I', 'O', 'U' };
            char[] buyukUnluHarflerInce = { 'E', 'İ', 'Ö', 'Ü' };
            List<char> list = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (buyukUnluHarflerInce.Contains(text[i]))
                {
                    list = text.ToUpper().Where(c => buyukUnluHarflerInce.Contains(c)).ToList();
                }
                else
                {
                    list = text.ToUpper().Where(c => buyukUnluHarflerKalin.Contains(c)).ToList();
                }
            }

            return list.Count > 0 && (buyukUnluHarflerInce.Contains(list[0]) || buyukUnluHarflerKalin.Contains(list[0]));
        }
    }
}
