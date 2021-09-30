using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ariel.HackerMe.DB
{
   public static class DbRegex
    {
        public static bool IsValidEmail(this string email)
        {
            Regex expression = new Regex(@"^.+(@)+(\D)+.+(com|co.il)");
            return expression.IsMatch(email);
        }
    }
}
