using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexText
{
    internal class TextFix
    {
        public string CleanText (string input)
        {
            if (input == null)
            {
                return string.Empty;
            }
            // Passo 1: Limpar o texto
            string cleanedText = Regex.Replace(input, @"[^\p{L}\p{N}\p{P}\s\uD83C-\uDBFF\uDC00-\uDFFF]+", "");

            // Passo 2: Substituir "donat" por "don't" e "itas" por "it's"
            cleanedText = cleanedText.Replace("donat", "don't").Replace("itas", "it's");



            return cleanedText;
        }
    }
}
