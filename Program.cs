using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Continuously update the clock
        while (true)
        {
            // Clear the console before printing the new time
            Console.Clear();

            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Format the time as HH:mm:ss
            string timeString = currentTime.ToString("HH:mm:ss");

            // Print the time in the center of the console window
            Console.SetCursorPosition((Console.WindowWidth - timeString.Length) / 2, Console.CursorTop);
            Console.Write(timeString);

            // Wait for one second before updating the time again
            Thread.Sleep(1000);
        }
    }
}

