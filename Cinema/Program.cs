using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main()
        {

            CinemaSits cinemaSits = new CinemaSits();

            Console.WriteLine("Please insert a letter for a column of your sit: ");
            char chosenColumnIndex = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please insert a number for a row of your sit: ");
            int chosenRowIndex = Convert.ToInt32(Console.ReadLine());

            int choose = cinemaSits[chosenRowIndex, chosenColumnIndex];
            Console.WriteLine("The sit {0} {1} is {2}", chosenRowIndex, chosenColumnIndex, choose);

            Console.WriteLine("Please insert a value of 1 for booking the chosen sit: ");

            int newNumber = Convert.ToInt32(Console.ReadLine());

            cinemaSits.SetSitNumber(newNumber, chosenRowIndex, chosenColumnIndex);

            cinemaSits.Display();




            Console.Read();
        }
    }
}
