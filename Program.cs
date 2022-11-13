using System;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // The first solution
            // Console.WriteLine("Is there current?(no = 0 & yes = 1): ");
            // Byte current = Convert.ToByte(Console.ReadLine());

            // Console.WriteLine("Is there healthy?(no = 0 & yes = 1): ");
            // byte healthy = Convert.ToByte(Console.ReadLine());

            // bool isOn = false;

            // if (current == 1 && healthy == 1)
            // {
            //    isOn = true;
            // }
            // Console.WriteLine(isOn);
            

            //The second solution
            Console.WriteLine("Is there current?(no = N & yes = Y): ");
            char charCurrent = Console.ReadKey().KeyChar;
            Console.WriteLine();
            byte[] current = Encoding.ASCII.GetBytes(charCurrent.ToString().ToUpper());

            Console.WriteLine("Is there healthy?(no = N & yes = Y): ");
            char charHealthy = Console.ReadKey().KeyChar;
            Console.WriteLine();
            byte[] healthy = Encoding.ASCII.GetBytes(charHealthy.ToString().ToUpper());
      
            bool isOn = false;

            if (current[0] == 89 && healthy[0] == 89)
            {
                isOn = true;
            }
            Console.WriteLine(isOn);
        }
    }
}
