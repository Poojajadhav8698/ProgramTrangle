using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sidea, sideb, sidec;
            Console.Write("\n\n");


            Console.WriteLine("input side 1st of triangle");
            sidea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input side 2nd of triangle");
            sideb = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("input side 3rd of triangle");
            sidec = Convert.ToInt32(Console.ReadLine());


            if(sidea ==sideb && sideb==sidec )
            {
                
                Console.WriteLine("This is equilateral  triangle");
            }
            else if(sidea==sideb || sidea==sidec || sideb==sidec)
            {
                if ((sidea * sidea > sideb * sideb + sidec * sidec) || (sideb * sideb > sidea * sidea + sidec * sidec) || (sidec * sidec > sidea * sidea + sideb * sideb))
                {
                    Console.WriteLine("This is invalide  triangle");
                }
                else
                {
                    Console.WriteLine("This is isocales triangle ");
                }
                
            }
            
            else if((sidea*sidea==sideb*sideb +  sidec*sidec)    || (sideb * sideb == sidea * sidea + sidec * sidec) || (sidec * sidec == sidea * sidea + sideb * sideb))
            {
                Console.WriteLine("This is right triangle ");
            }
            else 
            {
                Console.WriteLine("This is notspecial  triangle ");
            }

            Console.ReadKey();
        }
    }
}
