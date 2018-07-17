using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Montessori.Core
{
    public static class StringExtension
    {
        public static string ToSentenceCase(this string text)
        {
            var lowerCase = text.ToLower();
            // matches the first sentence of a string, as well as subsequent sentences
            var r = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
            // MatchEvaluator delegate defines replacement of setence starts to uppercase
            var result = r.Replace(lowerCase, s => s.Value.ToUpper());
            return result;
        }
    }
}
