using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketCenterCalculatorLibrary
{
    public class CenterCalculator
    {
        private int driver; // # of teeth on the driving sprocket
        private int driven; // # of teeth on the driven sprocket
        private double pitch; // pitch of the chain
        private double center; // desiered center distance

        private int large; // # of teeth on the larger sprocket
        private int small; // # of teeth on the smaller sprocket

        public void UpdateCalculator(int driveSprocket, int drivenSprocket, double pitch, double desiredCenter) // update class variables used in calculations
        {
            driver = driveSprocket; 
            driven = drivenSprocket;
            this.pitch = pitch;
            center = desiredCenter;

            large = Utilities.GetLargeSprocket(driven, driver); // return the larger of the two sprockets
            small = Utilities.GetSmallSprocket(driven, driver); // return the smaller of the two sprockets
        }

        public int[] LengthOptions() // get an array of the two options for chain length
        {
            double length = ChainLength.GetLength(center, pitch, large, small);// get the ideal decimal number of chain links based on the desired center distance...
            length = Math.Floor(length); // make that length an integer by removing the decimal (don't round up) because you can't have a decimal number of links...

            if (Utilities.TestEven(length) == true) // it's an even number of chain links...
            {
                int high = (int)length + 2; // the high option for number of chain links in the run should be 2 more than the calculated int length...
                return new int[2] { (int)length, high }; // return the high option and the even length as the two options for the chain length
            }
            else // it's an odd number of chain links...
            {
                int low = (int)length - 1; // the low option for number of chain links in the run should be one less than the calculated int length... 
                int high = (int)length + 1; // the high option for number of chain links in the run should be one less than the calculated int length...
                return new int[2] { low, high }; // return the low & high options for the chain length
            }

        }

        public double[] CentersOptions() // get the two options for the exact ceneter distance between the sprockets 
        {
            double shortCenter = ExactCenter.GetCenter(large, small, pitch, LengthOptions()[0]); // calculate longer option...
            double longCenter = ExactCenter.GetCenter(large, small, pitch, LengthOptions()[1]); // calculate shorter option...

            return new double[2] { shortCenter, longCenter }; // return both options
        }
    }
}
