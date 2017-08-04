using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketCenterCalculatorLibrary
{
    public static class ChainLength
    {
        private static double center;
        private static double pitch;
        private static int large;
        private static int small;

        private static double pitchCenter;
        private static double twoPi = 2 * Math.PI;

        public static double GetLength(double desierdCenter, double chainPitch, int largeSprocketTeeth, int smallSprocketTeeth)
        {
            center = desierdCenter;
            pitch = chainPitch;
            large = largeSprocketTeeth;
            small = smallSprocketTeeth;

            ToPitch();

            return AddSequince() + MultiplySequince();
        }

        private static void ToPitch()
        {
            pitchCenter = center / pitch;
        }

        private static double AddSequince()
        {
            return (2 * pitchCenter) + (large / 2.0) + (small / 2.0);
        }

        private static double MultiplySequince()
        {
            return (Math.Pow((large - small) / twoPi, 2)) * (1 / pitchCenter);
        }
        
    }
}
