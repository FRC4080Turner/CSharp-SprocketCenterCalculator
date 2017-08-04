using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketCenterCalculatorLibrary
{
    public class CenterCalculator
    {
        private int driver;
        private int driven;
        private double pitch;
        private double center;

        private int large;
        private int small;

        public void UpdateCalculator(int driveSprocket, int drivenSprocket, double pitch, double desiredCenter)
        {
            driver = driveSprocket;
            driven = drivenSprocket;
            this.pitch = pitch;
            center = desiredCenter;

            large = Utilities.GetLargeSprocket(driven, driver);
            small = Utilities.GetSmallSprocket(driven, driver);
        }

        public int[] LengthOptions()
        {
            double length = ChainLength.GetLength(center, pitch, large, small);
            length = Math.Floor(length);

            if (Utilities.TestEven(length) == true)
            {
                int high = (int)length + 2;
                return new int[2] { (int)length, high };
            }
            else
            {
                int low = (int)length - 1;
                int high = (int)length + 1;
                return new int[2] { low, high };
            }

        }

        public double[] CentersOptions()
        {
            double shortCenter = ExactCenter.GetCenter(large, small, pitch, LengthOptions()[0]);
            double longCenter = ExactCenter.GetCenter(large, small, pitch, LengthOptions()[1]);

            return new double[2] { shortCenter, longCenter };
        }
    }
}
