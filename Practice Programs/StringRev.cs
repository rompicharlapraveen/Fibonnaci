using System;

namespace Practice_Programs
{
    class StringRev
    {
        public static void Main(string[] args)
        {
            int l;
            string str1, str2 = "";
            Console.WriteLine("Enter Your String");
            str1 = Console.ReadLine();
            for(l=str1.Length-1;l>=0;l--)
            {
                str2 = str2 + str1[l];
            }
            Console.WriteLine(str2);
            Console.WriteLine("praveen.....");
            Console.ReadLine();
        }
    }
}
