using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ODEV_A_23.Helpers
{
    public class KucukUnluUyumu : TagHelper
    {
        public string Text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            if (Methot(Text))
            {
                output.Content.SetContent("Kucuk unlu uyumunu uyar");
            }
            else
            {
                output.Content.SetContent("Kucuk unlu uyumunu uymaz");

            }
        }

        private bool Methot(string text)
        {
            char[] gurup1 = { 'a', 'e', 'ı', 'i' };
            char[] gurup2 = { 'o', 'ö', 'u', 'ü' };
            char[] gurup3 = { 'a', 'e', 'u', 'ü' };

            List<char> chars = new List<char>();

            foreach (var ch in text)
            {
                if (gurup1.Contains(ch) || gurup2.Contains(ch))
                {
                    chars.Add(ch);
                }
            }
            //for (int i = 0; i < text.Length; i++)
            //{
            //    char a = text[i];
            //    if (Array.IndexOf(gurup1, a) != -1 || Array.IndexOf(gurup2, a) != -1)
            //    {
            //        chars.Add(a);
            //    }
            //}

            for (int i = 0; i < chars.Count - 1; i++)
            {
                char currentWord = chars[i];
                char nextWord = chars[i + 1];
                if (Array.IndexOf(gurup1, currentWord) != -1 && Array.IndexOf(gurup1, nextWord) != -1)
                {
                    continue;
                }
                else if (Array.IndexOf(gurup2, currentWord) != -1 && (Array.IndexOf(gurup3, nextWord) != -1))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
    }
}
