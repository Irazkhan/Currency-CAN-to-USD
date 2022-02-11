using System;

namespace Currency_CAN_to_USD   //project file saved by Vasilev Irazkhan 
{
    internal class Conversion 
    {
        static void Main(string[] args)
        {
            int inc_value;   // chosen variable is inc_value 

            while (true) // while the program is true, program makes outputs from 0-200 
            {
                Console.Write("Enter value between 5 - 25: ");
                inc_value = Convert.ToInt32(Console.ReadLine()); // convert int for unknown input  

                if (inc_value >= 5 && inc_value <= 25) ; // if input value x=>5 and <=25, we get USD conversion 
                                                         // if input is not on the range, we get: try again 

                {
                    break;
                }

                Console.WriteLine("value must be between 5 - 25.. try again ");
            }
            double CAD = 0, USD;  //  set dataset and choose defalut value = 0
            Console.WriteLine("CAD   US$"); // show output for user 
            Console.WriteLine("---------------------------"); 

            do // 1 USD is 0.792367  
            {
                USD = CAD * 0.792367;
                Console.WriteLine(CAD + "    " + USD);
                CAD += inc_value; // assign result value 
            }
            while (CAD <= 200); // values stop until 200 

        }
    }
}
