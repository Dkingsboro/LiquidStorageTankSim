using System.Diagnostics.Metrics;
using static System.Console;
namespace LiquidStorageTankSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StorageTank st1 = new StorageTank(); // Creates new storage tank st1 with no argument constructor with the values defines below st1.Length = 6.5;
            st1.Width = 7;
            st1.Height = 8;

            WriteLine($"Capacity of the tank = {st1.Capacity():F4} gallons"); // Displays the complete capacity of the tank. This information is calculated using the Capacity method

            if(st1.Add(50))  // Calls Add method to tell if 50 gallons is added to the tank, is it possible or not.Decides in a boolean.
            {
                WriteLine("50 gallons added to the tank");
            }
            else
            {
                WriteLine("Failed to add 50 gallons");
            }

            if (st1.Remove(30)) // Calls Remove method to decide if the proposed gallons are able to be removed.If not, provides a fail statement
            {
                WriteLine("30 gallons removed from the tank");
            }
            else
            {
                WriteLine("Failed to remove 30 gallons");
            }

            if (st1.Remove(70)) // Calls Remove method to decide if the proposed gallons are able to be removed.If not, provides a fail statement.
            {
                WriteLine("Failed to remove 70 gallons");
            }
            else
            {
                WriteLine("Not enough liquid to remove 70 gallons");
            }

            WriteLine("Current gallons after all add and remove = " + st1.CurrentGallons); // Displays how much liquid is in the tank after addition and removal
            WriteLine($"The tank is {st1.GetPercentFull():f2}% full"); // Displays how full the tank is after addition and removal in a percentage

            // Displays ToString that is referenced in StorageTank Class
            WriteLine(st1.ToString());

            WriteLine("\n" + "\n" + "Test 2:" + "\n"); // Just creates some space between the two tests in order to clean up

            // Test 2
            StorageTank st2 = new StorageTank(7.5, 5, 10); // Creates new Storage Tank st2.

            WriteLine("Capacity of the tank = " + st2.Capacity() + " gallons"); // Displays the complete capacity of the tank. This information is calculated using the Capacity method

            if (st2.Add(120)) // Calls Add method to add liquid to the tank, and then caclulate percent full to display out.
            {
                WriteLine($"The tank is {st2.GetPercentFull():f4}% full");
            }
            else
            {
                WriteLine("Failed to add 120 gallons");
            }

            if (st2.Add(150)) // Calls Add method to add liquid to the tank, and then caclulate percent full to display out.
            {
                WriteLine($"The tank is {st2.GetPercentFull():f3}% full");
            }
            else
            {
                WriteLine("Failed to add 150 gallons");
            }

            WriteLine(st2.ToString()); // Displays ToString that is referenced in StorageTank Class
        }
    }
}