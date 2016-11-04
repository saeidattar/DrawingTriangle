using System;

namespace DrawingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string character;
            int height;
            Console.WriteLine("Please enter you're character:");
            character = Console.ReadLine();
            Console.WriteLine("Please Enter you're height:");
            height = Convert.ToInt32(Console.ReadLine());
            
            // Drawinloop 
            for (int i = 0; i < height; i++)
            {
                // create space character
                for (int K = 0; K < height - i; K++) // OR===> for (int k = i; k < height; k++)
                {
                    Console.Write("{0}", " ");
                }

                //create by My chracter
                for (int j = 0; j < 2 * i + 1; j++)
                {              
                    Console.Write("{0}", character);
                }
                Console.WriteLine();
            }//end Drawinloop

            Console.ReadKey();
        } //end Main

    }
}