// See https://aka.ms/new-console-template for more information
using UtilityKnife.Converters;

namespace UtilityKnife
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // skeleton program
            var converter = new FahrenheitToCelsius();
            var celsius = converter.FahrenheitToCelsiusConverter(212.0);
            Console.WriteLine($"Fahrenheit temp of 212 is {celsius}.");
        }
    }
}
