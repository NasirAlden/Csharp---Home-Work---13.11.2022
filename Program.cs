using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp___Home_Work___13._11._2022
{
    class Program
    {
        static string CharsToStars(string str, string subStr)
        {
            string tmpStr = "";
            for (int i = 0; i < subStr.Length; ++i)
            {
                tmpStr+='*' ;
            }
            return str.Replace(subStr,tmpStr);
        }
        static void Main(string[] args)
        {
            // contains()
            string str1 = "Nasir Alden";
            string str2 = "sir";
            Console.WriteLine("String 1 = " + str1);
            Console.WriteLine("String 2 = " + str2);
            if (str1.Contains(str2))
            {
                Console.WriteLine("String 1 (\"{0}\") contains String 2 (\"{1}\")", str1, str2);
            }
            else {
                Console.WriteLine("String 1 (\"{0}\") not contains String 2 (\"{1}\")", str1, str2);
            }

            //CopyTo()
            char[] str3 = new char[10];
            str1.CopyTo(2, str3, 0, 7);
            Console.WriteLine(str3);

            //insert()
            Console.WriteLine(str1.Insert(6, "Hamad "));

            //PadRight()
            Console.WriteLine(str1.PadRight(15)+"!");

            //str.Replace()
            Console.WriteLine(str1.Replace("N","NNN")) ;

            //Substring()
            Console.WriteLine(str1.Substring(6));

            //ToCharArray()
            char[] chars = str1.ToCharArray();
            Console.Write("Character array :");
            for (int i = 0; i < chars.Length; i++)
                Console.Write(" " + chars[i]);
            Console.WriteLine();
            //Split()
            String[] params1 = {" "};
            String[] strlist = str1.Split(params1, 2 ,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(strlist[0], strlist[1]);

            //Trim()
            string str4 = "    Nasir";
            Console.WriteLine("Before trim:"+ str4);
            Console.WriteLine("After trim:" + str4.Trim());

            //TrimStart()
            string str5 = "$$$%%%%##Nasir##%%%%$$$";
            char[] charsToTrim = { '#', '$','%' };
            Console.WriteLine(str5.TrimStart(charsToTrim));

            //StartsWith()
            Console.WriteLine(str1.StartsWith("Na"));

            //IndexOf()
            int index1 = str1.IndexOf('S');
            Console.WriteLine(index1);
            int index2 = str1.IndexOf('s');
            Console.WriteLine(index2);

            //  Exercise - Function to replace substring with stras (*)
            Console.WriteLine(CharsToStars(str1,"den")); 


            Console.ReadKey();
        }

        
    }
}
