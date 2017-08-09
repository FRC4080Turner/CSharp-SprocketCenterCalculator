using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterCalculatorGUI
{
    public static class InputValidator 
        /* this checks user inputs to make sure 
         * they can be fed to the calculator 
         * without thoowing ecceptions */ 
    {
        private static double AnsiToPitch(string ansi) // converts an ansi trade size such as #35 to it's corresponding decimal pitch (#35 = 0.375") 
        {
            double decPitch = 0; 
            char hash = ansi[0]; 

            if (ansi.Length == 3 && hash == '#') // for trade #'s from #25 to #80 (3 char string)
            {
                /* get the first digit (ignore the hash), convert it to a numeric data type,
                 * and multiply by 1/8" to get the decimal pitch */
                decPitch = .125 * Convert.ToDouble(Convert.ToString(ansi[1]));
            }
            else if(ansi.Length == 4 && hash == '#') // for trade #'s from #100 to #160 (4 char string)
            {
                /* get the first two digits (ignore the hash), create a two digit number,
                 * convert it to a numeric data type,
                 * and multiply by 1/8" to get the decimal pitch */
                decPitch = .125 * Convert.ToDouble(Convert.ToString(ansi[1] + ansi[2]));
            }
            else // it isn't in the form #25 or #100 it isn't a trade #
            {
                decPitch = -1; // use a -1 to signify an unusable value
            }

            return decPitch; // return a decimal pitch or -1
        }

        public static double GetPitch(string input) // gets the user input for pitch and returns a decimal value
        {
            double output = 0;

            if (input[0] == '#') // is the first char the hash?
            {
                output = AnsiToPitch(input); // convert the ANSI number to a decimal number and set output to it
            }
            else // dosen't start with the hash
            {
                try
                {
                    double x = Convert.ToDouble(input); // any valid input for the calculator that isn't an ANSI # can be converted to a double
                    if (x < 25) // inputs of less than 25 are concidered to be the exact pitch
                    {
                        output = x; // set output to the user value
                    }
                    else // this assumes the user entered an ANSI trade number without the hash char at the front
                    {
                        if (input.Length == 2) // is it two digits?
                        {
                            /* get the first digit (ignore the hash), convert it to a numeric data type,
                            * and multiply by 1/8" to get the decimal pitch */
                            output = Convert.ToDouble(Convert.ToString(input[0])); // get the 
                        }
                        else if (input.Length == 3) // is it three digits?
                        {
                            /* get the first two digits (ignore the hash), create a two digit number,
                            * convert it to a numeric data type,
                            * and multiply by 1/8" to get the decimal pitch */
                            output = Convert.ToDouble(Convert.ToString(input[0] + input[1]));
                        }
                        else // the input was to long or short
                        {
                            output = -1;
                        }
                    }
                }
                catch (Exception) // the input was in an incorrect form
                {
                    output = -1;
                }

            }
        
            return output;
        }

        public static double GetCenter(string userInput) // chaeck that the entry for center distance is a valid decimal
        {
            try
            {
                double center = Convert.ToDouble(userInput); // try to convert to a double and...
                return center; // return it if it will convert
            }
            catch (Exception)
            {
                return -1; // if it won't return -1 because it isn't a valid input
            }
        }
    }
}
