using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace arrays
{
    public class Program
    {
        public static void Main()
        {
            string str = "zwzakiirr";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(str[i]+"-"+count);
            //}
            foreach (var letter in str)
            {
                int count = 0;

                foreach (var allLetter in str)
                {
                    if(allLetter == letter)
                    {
                        count++;
                    }
                }

                Console.WriteLine(letter+"-"+count);
            }

        }
    }
}
