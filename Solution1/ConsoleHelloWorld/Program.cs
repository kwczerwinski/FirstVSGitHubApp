using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string message1 = "Hello";
            //string message2 = "World";
            //Console.Write("{0} {1}\n", message1, message2);

            //ConsoleKeyInfo pressedKey = Console.ReadKey();
            //Console.WriteLine();
            //char pressedKeyCode = pressedKey.KeyChar;

            //char pressedKeyCode = Console.ReadKey().KeyChar;
            //Console.WriteLine(pressedKeyCode);
            //Console.ReadKey();

            //if (Console.ReadKey().KeyChar == 'a')
            //    Console.WriteLine("a");

            //int keyCode = Console.ReadKey().KeyChar - 48;
            //Console.WriteLine(keyCode);
            //Console.Clear();
            //if ((keyCode > -1) && (keyCode < 10))
            //    Console.Write("{0} {1}", keyCode, keyCode / 2);

            int keyCode = 0, result = 0;
            while(keyCode != 13)
            {
                keyCode = Console.ReadKey().KeyChar;
                if ((keyCode > 47) && (keyCode < 58))
                    result = result * 10 + keyCode - 48;
                else if(keyCode == 8)
                    result = result / 10;
                Console.Clear();
                Console.Write("{0} {1}", result, result/2);
            }

            //Console.Write((int)Console.ReadKey().KeyChar);

            //Console.ReadKey();

        }
    }
}
