namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What fahrenheit temperature would you like to convert to celsius?");
            var valid = double.TryParse(Console.ReadLine(),out double userInput);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What celsius temperature would you like to convert to fahrenheit?");
            var isValid = double.TryParse(Console.ReadLine(), out double userInput2);
            Console.WriteLine();
            Console.WriteLine();

            var celcius = TempConverter.FahrenheitToCelsius(userInput);
            Console.WriteLine($"Your first temperature is {celcius}");
            var fahrenheit = TempConverter.CelciusToFahrenheit(userInput2);
            Console.WriteLine($"Your second temperature is {fahrenheit}");
            

        }
    }
}
