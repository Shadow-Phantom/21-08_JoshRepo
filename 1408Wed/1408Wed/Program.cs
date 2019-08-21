using System;

namespace _1408Wed
{
    class Program
    {
        static void Main(string[] args)
        {
            //W3T1
            int count = 0;
            while (count < 10)
            {
                
                count += 1;
                Console.Write(count + " ");
                
                
            }

            Console.WriteLine();
            //W3T2
            int counter = 0;

            while (counter < 20)
            {
                counter += 2;
                
                Console.Write(counter + " ");
                
                
            }

            Console.WriteLine();
            //W3T3
            string output = " ";
            string magicNum = "5";

            
            while (output != magicNum)
            {
                Console.WriteLine("what is ma magic number?");
                output = Console.ReadLine();
            }
            Console.WriteLine("u too smart >:(");

            Console.WriteLine();
            //W3T4
            int lastNum = 0;
            int num = 0;
            int counter5 = 0;

            Console.Write("gimme a number: ");
            string userOutput = Console.ReadLine();
            num = Convert.ToInt32(userOutput);
            string finalOutput = "";
            while (lastNum < num)
            {
                counter5++;
                lastNum = lastNum + counter5;
                finalOutput = finalOutput + "" + counter5 + " + ";
            }
            Console.WriteLine(num + " = " + finalOutput + "= " + num);

            Console.WriteLine();

            //W3T5
            string answer = "It gets wet";
            string plrAnswr = "";
            while (plrAnswr != answer)
            {
                Console.Write("What happens when you throw a yellow rock in the red sea? answer: ");
                plrAnswr = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("and you will probably get wet too if you're not too careful :)");
            Console.WriteLine();

            //W3T6
            Random random = new Random();
            int secretNumber = random.Next(1, 1000);
            int tryNum = 0;
            int maNumber = 0;
            bool correct = false;
            while (tryNum <= 10)
            {
                Console.WriteLine("the number we need is: " + secretNumber);
                if (maNumber != secretNumber)
                {
                    tryNum++;
                    Console.WriteLine("guess me number >:)");
                    string bob = Console.ReadLine();
                    maNumber = Convert.ToInt32(bob);
                }
                else
                {
                    correct = true;
                    break;
                }
                
                
            }

            if (correct)
            {
                Console.WriteLine("Correct-a-mando!");
            }
            else
            {
                Console.WriteLine("oof, wrong try again next time");
            }
            

        }
    }
}
