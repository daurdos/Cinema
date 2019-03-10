using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class CinemaSits
    {
        private int RowIndex { get; set; } = 9;
        private int ColumnIndex { get; set; } = 15;

        int [,] arCinemaSits;

        public CinemaSits()
        {
            arCinemaSits = new int[RowIndex, ColumnIndex];

            for (int i = 0; i < RowIndex; i++)
            {
                for (int j = 0; j < ColumnIndex; j++)
                {
                    arCinemaSits[i, j] = 0;
                }
            }

            Display();
        }


        public int this[int rowIndex, int columnIndex]
        {
            get
            {
                if ((rowIndex <= RowIndex) && (columnIndex <= ColumnIndex))
                    return arCinemaSits[rowIndex, columnIndex];
                else
                    return 0;
            }

            set
            {
                arCinemaSits[columnIndex, rowIndex] = value;
            }
        }





        public void SetSitNumber(int newNumber, int choosenRowIndex, char choosenColIndex)
        {

            if (choosenColIndex == 'a')
            {
                arCinemaSits[choosenRowIndex - 1, 0] = newNumber;
            }
            else if (choosenColIndex == 'b')
            {
               arCinemaSits[choosenRowIndex - 1, 1] = newNumber;
            }
            else if (choosenColIndex == 'c')
            {
                arCinemaSits[choosenRowIndex - 1, 2] = newNumber;
            }

        }


        public void Display()
        {
            int counter = 0;

            Console.Write("Row|Col");
            Console.WriteLine(" A B C D E F G H I J K L M N O");

            for (int i = 0; i < RowIndex; i++)
            {
                counter = counter + 1;
                Console.Write(" {0}      ", counter);

                for (int j = 0; j < ColumnIndex; j++)
                {
                    Console.Write("{0} ", arCinemaSits[i, j]);
                }
                Console.WriteLine();
            }
        }

        /*
        public void SetSitNumber(int newNumber, int choosenRowIndex, char choosenColIndex)
        {
            newNumber = GetRowColIndex(choosenRowIndex, choosenColIndex);
            arCinemaSits
        }
        */

    }
}
