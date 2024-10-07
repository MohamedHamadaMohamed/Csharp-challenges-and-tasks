


namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

          List<int> list = new List<int>();
          char input;
            do
            {
                PrintChoise();
                Console.Write("Enter your choise : ");
                input = char.Parse(Console.ReadLine().ToLower());
                switch(input)
                {
                    case 'p': printList(list); break;
                    case 'a':
                        int newItem =0;
                        Console.Write("enter the number which you add : ");
                        newItem = int.Parse(Console.ReadLine());
                        list.Add(newItem);
                        Console.Write($"{newItem} added");
                        break;
                    case 'm': displayMean(list); break;
                    case 's': displaySmallest(list); break;
                    case 'l': displayLargest(list); break;
                    case 'f': findNumber(list); break;
                    case 'c': list.Clear(); break;
                    case 'q': Console.WriteLine("good Bye "); break;
                    default : Console.WriteLine("Unknown seleection ,please try again");  break;

                }
            } while (input != 'q') ;
        }

        private static void findNumber(List<int> list)
        {
            Console.Write("enetr the number which search it :  ");
            int item = int.Parse(Console.ReadLine());
            for(int i =0;i<list.Count;i++)
            {
                if (list[i] == item)
                {
                    Console.WriteLine($"the index of {item } is {i}");
                    return;
                }

            }
            Console.WriteLine("the number is not exist");
        }

        private static void displayLargest(List<int> list)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest - no data");
            }
            else
            {
                int l = list[0];
                for(int i =1;i<list.Count;i++)
                {
                    if(l < list[i])
                    {
                        l = list[i];
                    }
                }
                Console.WriteLine($"the largest number is {l}");
            }
        }

        private static void displaySmallest(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest - no data");
            }
            else
            {
                int s = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (s > list[i])
                    {
                        s = list[i];
                    }
                }
                Console.WriteLine($"the largest number is {s}");
            }
        }

        static public void displayMean(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                double mean;
                int sum = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
                mean = sum / list.Count;
                Console.WriteLine($"mean = {mean}");
            }
        }
        private static void printList(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("[] the list is empty ");
            }
            else
            {
                Console.Write("[ ");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]);
                    Console.Write(' ');
                }
                Console.WriteLine("]");
            }
        }

        static void PrintChoise()
        {
            Console.WriteLine(" ------------------------------------ ");
            Console.WriteLine("| P - Print numbers                  |");
            Console.WriteLine("| A - Add anumber                    |");
            Console.WriteLine("| M - display mean of the numbers    |");
            Console.WriteLine("| S - display the Smallest number    |");
            Console.WriteLine("| L - display the largest number     |");
            Console.WriteLine("| F - search for a number            |");
            Console.WriteLine("| C - Clear the list                 |");
            Console.WriteLine("| Q - Quit                           |");
            Console.WriteLine(" ------------------------------------ ");
        }

    }
}
