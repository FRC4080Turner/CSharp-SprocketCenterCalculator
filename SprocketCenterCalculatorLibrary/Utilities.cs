using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketCenterCalculatorLibrary
{
    public static class Utilities
    {
        public static bool TestEven(int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool TestEven(double input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetLargeSprocket(int sprocketTwo, int sprocketOne)
        {
            if(sprocketOne > sprocketTwo)
            {
                return sprocketOne;
            }
            else
            {
                return sprocketTwo;
            }
        }

        public static int GetSmallSprocket(int sprocketTwo, int sprocketOne)
        {
            if (sprocketOne < sprocketTwo)
            {
                return sprocketOne;
            }
            else
            {
                return sprocketTwo;
            }
        }

        public static double AnsiToPitch(string ansi)
        {
            char[] inputChar = ansi.ToCharArray();
            string firstDigit = "";

            if (ansi.Length == 2)
            {
                firstDigit = ansi.Substring(0, 1);
            }
            else
            {
                firstDigit = ansi.Substring(0, 2);
            }

            double pitch;
            pitch = Convert.ToDouble(firstDigit) * 0.125;
            return pitch;
        }

        public static double getTorqueRatio(int drivingSprocket, int drivenSprocket)
        {
            return drivenSprocket / drivingSprocket;
        }
    }
}
