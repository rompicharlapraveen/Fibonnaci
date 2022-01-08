using System;

namespace Practice_Programs
{
    class Fibanocci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, a;
            Console.WriteLine("Enter the element: ");
            a = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");    
            for (i = 0; i < a; i++)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine("praveen");
             Console.WriteLine("ROM");
            Console.ReadLine();
        }
    }
}
