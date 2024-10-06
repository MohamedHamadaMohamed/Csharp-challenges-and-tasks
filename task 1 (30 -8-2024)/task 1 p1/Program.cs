using System.Runtime.ConstrainedExecution;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Islam's Carpet Cleaning Service
                 Charges:
                        $25 per small room
                        $35 per large room
                Sales tax rate is 6%
                Estimates are valid for 30 days
             */
            Console.Write("Number of small rooms: ");
            int numOfSmallRooms = int.Parse(Console.ReadLine());

            Console.Write("Number of large rooms: ");
            int numOfLargeRooms = int.Parse(Console.ReadLine());

            double PricePerSmallRoom =Convert.ToDouble(numOfSmallRooms*25 );
            double PricePerLargeRoom = Convert.ToDouble(numOfLargeRooms * 35);
            double cost = PricePerSmallRoom + PricePerLargeRoom;
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${cost*.06}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${cost*1.06}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
