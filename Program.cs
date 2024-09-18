using System.Diagnostics;

namespace Tisdags_projektet
{
    using System.Diagnostics;

    namespace Tisdags_projektet
    {
        internal class Program
        {

            static int IntErrorInput(int input, int min, int max)
            {
                bool error = true;

                while (error)
                {

                    if (input >= min && input <= max)
                    {
                        error = false;
                    }
                    else
                    {

                        Console.WriteLine($"Ojdå. Vänligen skriv in ett tal mellan {min} och {max}: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        separator();

                    }
                }
                return input;
            }
            static void separator()
            {
                Console.WriteLine("---------------------------------------------------------------------");
            }
            static void Main(string[] args)
            {
                //unicode to show the emojis, and setting a unicode standard output
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                Random random = new Random();

                bool playAgain = true;
                while (playAgain == true)
                {
                    int numOne = random.Next(1, 51);
                    int numTwo = random.Next(1, 51);
                    int numThree = random.Next(1, 51);

                    while (numTwo == numOne)
                    {
                        numTwo = random.Next(1, 51);
                    }

                    while (numThree == numTwo || numThree == numOne)
                    {
                        numThree = random.Next(1, 51);
                    }

                    Console.WriteLine("Hur många lotter vill du köpa? max 5st: ✋");
                    int lotteryAmount = Convert.ToInt32(Console.ReadLine());
                    lotteryAmount = IntErrorInput(lotteryAmount, 1, 5);
                    separator();

                    int[] myLottery = new int[lotteryAmount];


                    Console.WriteLine($"Skriv in {lotteryAmount}st lotto nummer mellan 1-50.");
                    Console.WriteLine("Hoppas att du vinner \U0001f91e");


                    for (int i = 0; i < lotteryAmount; i++)
                    {
                        Console.WriteLine($"Din lotto nummer {i + 1}: ");
                        myLottery[i] = Convert.ToInt32(Console.ReadLine());
                        separator();
                        myLottery[i] = IntErrorInput(myLottery[i], 1, 50);
                    }

                    for (int i = 0; i < myLottery.Length; i++)
                    {
                        if (myLottery[i] == numOne)
                        {
                            Console.WriteLine($"Grattis du vann. Vinnande nummret är {numOne}.🥳");
                        }
                        else if (myLottery[i] == numTwo)
                        {
                            Console.WriteLine($"Grattis du vann. Vinnande nummret är {numTwo}.🥳");
                        }
                        else if (myLottery[i] == numThree)
                        {
                            Console.WriteLine($"Grattis du vann. Vinnande nummret är {numThree}.🥳");
                        }
                        else
                        {
                            Console.WriteLine($"{myLottery[i]} vann inte tyvärr 😢.");
                        }
                    }

                    separator();
                    Console.WriteLine($"Veckans vinnande nummer är {numOne}, {numTwo} och {numThree} 😊.");

                    Console.WriteLine("Vill du spela igen? ja/nej ");
                    string againPlay = Console.ReadLine();

                    if (againPlay == "ja")
                    {
                        Console.WriteLine("Spelet börjar igen!😀");
                    }
                    else
                    {
                        Console.WriteLine("Spelet avslutas. Tryck på Enter för att avsluta.🤗");
                        playAgain = false;
                    }

                }
                Console.ReadLine();





            }
        }
    }

}
