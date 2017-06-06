using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC Inc: XManufacturing System");

            int userInput = 0;

            do
            {
                Console.WriteLine();
                userInput = MainMenu();

                switch (userInput)
                {
                    case 1:
                        Widget_X Widget_X_01 = new Widget_X();
                        Console.WriteLine("\nNew Widget X created: Widget_X_01");

                        //Console.WriteLine("Enter sku-ID:");
                        //Widget_X_01.Sku_ID = Convert.ToInt32(Console.ReadLine());

                        //Console.WriteLine("Enter date-MFG:");
                        //Widget_X_01.DateMFG = Console.ReadLine();

                        //Console.WriteLine("New Widget X created with the following properties:\n sku-ID = " + Widget_X_01.Sku_ID + "\n Date-MFG = " + Widget_X_01.DateMFG);

                        Widget_X_01.Sku_ID = 8712;
                        Console.WriteLine(" sku-ID = " + Widget_X_01.Sku_ID);
                        Widget_X_01.DateMFG = "10/10/16";
                        Console.WriteLine(" date-MFG = " + Widget_X_01.DateMFG);

                        break;

                    case 2:
                        Part_G Part_G_X = new Part_G();
                        Part_G_X.BatchID = 102016;
                        Console.WriteLine("\nNew Part G created: Part_G_X\n Batch-ID = " + Part_G_X.BatchID);
                        break;

                    case 3:
                        Part_L Part_L_X = new Part_L();
                        Part_L_X.BatchID = 201023;
                        Part_L_X.InspectorID = "Emp8711";
                        Console.WriteLine("\nNew Part L created: Part_L_X\n Batch-ID = " + Part_L_X.BatchID + "\n Inspector-ID = " + Part_L_X.InspectorID);

                        break;
                } // end switch block

            } while (userInput < 4); // exit when user enters 4// end do loop
            //while statement is written immediately following the closing } of the do loop.
        } // end Main

        public static int MainMenu()
        {
            Console.WriteLine("Main Menu\n");
            Console.WriteLine(" 1. Create New Widget X");
            Console.WriteLine(" 2. Create New Part G");
            Console.WriteLine(" 3. Create New Part L");
            Console.WriteLine(" 4. Exit\n");


            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

    }
}
