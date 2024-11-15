namespace NameDayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of the day of the week");
            string customersInputValue = Console.ReadLine(); //ввід користувача

            //switch
            string dayOfWeek = customersInputValue switch
            {
                "1" => "Monday",
                "2" => "Tuesday",
                "3" => "Wendnesday",
                "4" => "Thuersday",
                "5" => "Friday",
                "6" => "Saturday",
                "7" => "Sunday",
                  _ => "Incorrect input. Please try again"
            };

            Console.WriteLine(dayOfWeek);
        }
    }
}
