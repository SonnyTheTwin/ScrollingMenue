using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;


namespace ScrollingMenue
{
    internal class Menue
    {
        private string[] Options; 
        private string Prompt; 
        private int SelectedIndex = 0;
        public Menue(string[] options, string prompt)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
           

        }
        private void DisplayOptions()
        {
            ForegroundColor = ConsoleColor.DarkCyan;

            WriteLine(Prompt); 

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i]; 
                string prefix;
                if (i == SelectedIndex) 
                {
                    prefix = "\x1b[36m\x1b[24m <> \x1b[4m";  
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.DarkCyan;
                    BackgroundColor = ConsoleColor.Black;
                }
                 


                WriteLine("" + prefix + "" + currentOption + "" + prefix); 
            }
            ResetColor(); 
        }
        public int Run()
        {
            ConsoleKey keypressed; 
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyinfo = ReadKey(true); 
                keypressed = keyinfo.Key; 
                if (keypressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--; 
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1; 
                    }
                }
                if (keypressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;                     
                    if (SelectedIndex == Options.Length) 
                    {
                        SelectedIndex = 0; 
                    }
                }
                if (keypressed == ConsoleKey.Enter)
                {

                }

            } while (keypressed != ConsoleKey.Enter); 

            return SelectedIndex;
        }

    }
}