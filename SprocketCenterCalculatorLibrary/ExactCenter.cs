using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketCenterCalculatorLibrary
{
    public static class ExactCenter
    {
        private static double parenOne;
        private static int nN;

        public static double GetCenter(int LargeSprocketTeeth, int SmallSprocketTeeth, double Pitch, int LengthInPitches)
        {
            int large = LargeSprocketTeeth;
            int small = SmallSprocketTeeth;
            double pitch = Pitch;
            int length = LengthInPitches;

            nN = large - small;
            parenOne = 2 * length - large - small;

            return ((pitch / 8) * (UnderRad() + parenOne));
        }

        private static double UnderRad()
        {
            double x = (parenOne * parenOne) - (0.81 * Math.Pow(nN, 2));
            return Math.Sqrt(x);
        }
    }
}
