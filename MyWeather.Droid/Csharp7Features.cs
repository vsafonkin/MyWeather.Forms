using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeather.Droid
{
    public class CsharpSevenFeatures
    {
        private string userName;

        public CsharpSevenFeatures()
        {
            // tuples
            Debug.WriteLine(GiveMeATuple().Item1);

            // Digit separators and binary literals
            var oneMillion = 1_000_000;
            var twentySeventeen = 20_1_7;
            var x = 0b00010011_00000011_00011001;
            Debug.WriteLine($"{oneMillion},{twentySeventeen},{x}");

            // Out variables
            if (int.TryParse(UserName ?? "123", out int quantity))
                Debug.WriteLine(quantity);
            else
                Debug.WriteLine("Quantity is not a valid integer!");

            Debug.WriteLine($"{GetCylinderVolume(108, 42)}");
        }

        // Expression-bodied members (constructor)
        // throw Expressions
        public CsharpSevenFeatures(string userName) => UserName = userName ?? throw new ArgumentNullException(nameof(UserName));

        // Expression-bodied members (property)
        public string UserName
        {
            get => userName;
            private set => userName = value;
        }

        // Type inference
        public (int sum, double average) Measure(List<int> items)
        {
            var stats = (sum: 0, average: 0d);
            stats.sum = items.Sum();
            stats.average = items.Average();
            return stats;
        }

        // Use with generics and async
        public async Task<(string value, int count)> GetValueAsync()
        {
            await Task.Delay(100);
            string fooBar = "foo bar";
            int num = 123;

            return (fooBar, num);
        }

        // Local functions
        double GetCylinderVolume(double radius, double height)
        {
            return getVolume();

            double getVolume()
            {
                // You can declare inner-local functions in a local function 
                double GetCircleArea(double r) => Math.PI * r * r;

                // ALL parents' variables are accessible even though parent doesn't have any input. 
                return GetCircleArea(radius) * height;
            }
        }

        (string, int) GiveMeATuple()
        {
            return ("New York", 7891957);
        }
    }
}