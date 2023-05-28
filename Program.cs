// See https://aka.ms/new-console-template for more information
using System;

namespace ScrollingMenue 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prompt = @"INTRO SCREEN INSERT HERE ";
            string[] Options = { "Option A", "Option B", "Option C", "Back/Exit" }; 
            Menue mainMenue = new Menue(Options, prompt);
            int selectedChoice = mainMenue.Run();
        }
    }
}