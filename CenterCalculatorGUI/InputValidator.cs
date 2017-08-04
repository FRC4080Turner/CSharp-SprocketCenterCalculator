using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterCalculatorGUI
{
    public static class InputValidator
    {
        private static double AnsiToPitch(string ansi)
        {
            double decPitch = 0;
            char hash = ansi[0];

            if (ansi.Length == 3 && hash == '#')
            {
                decPitch = .125 * Convert.ToDouble(Convert.ToString(ansi[1]));
            }
            else if(ansi.Length == 4 && hash == '#')
            {
                decPitch = .125 * Convert.ToDouble(Convert.ToString(ansi[1] + ansi[2]));
            }
            else
            {
                decPitch = -1;
            }

            return decPitch;
        }

        public static double GetPitch(string input)
        {
            double output = 0;

            if (input[0] == '#')
            {
                output = AnsiToPitch(input);
            }
            else
            {
                try
                {
                    double x = Convert.ToDouble(input);
                    if (x < 25)
                    {
                        output = x;
                    }
                    else
                    {
                        if (input.Length == 2)
                        {
                            output = Convert.ToDouble(Convert.ToString(input[0]));
                        }
                        else if (input.Length == 3)
                        {
                            output = Convert.ToDouble(Convert.ToString(input[0] + input[1]));
                        }
                        else
                        {
                            output = -1;
                        }
                    }
                }
                catch (Exception)
                {
                    output = -1;
                }

            }
        
            return output;
        }

        public static double GetCenter(string userInput)
        {
            try
            {
                double center = Convert.ToDouble(userInput);
                return center;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
