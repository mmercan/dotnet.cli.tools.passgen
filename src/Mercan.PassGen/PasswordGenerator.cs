using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercan.PassGen
{
    public class PasswordGenerator
    {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string validSymbols = "!@#$%^&*()_-+,.{}[]";
        public static string Generate(ArgsOptions agrs)
        {
            var numberofchars = valid.Length;
            if (!agrs.ExcludeSymbols){
                 numberofchars +=validSymbols.Length;;
            }
            
            Random rnd = new Random();
            int howManyChars  = rnd.Next(agrs.MinLength, agrs.MaxLength);
           

            StringBuilder res = new StringBuilder();
            for (int i = 0; i < howManyChars; i++)
            {
               var num =  rnd.Next(numberofchars);
               if(num > valid.Length){
                    res.Append(validSymbols[num - valid.Length]);
               }else{
                res.Append(valid[num]);
               }
            }

            return res.ToString();
          
        }
    }
}