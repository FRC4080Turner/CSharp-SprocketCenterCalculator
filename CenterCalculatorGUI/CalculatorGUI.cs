using SprocketCenterCalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterCalculatorGUI
{
    public partial class centerCalculatorGUI : Form
    {
        CenterCalculator calc = new CenterCalculator();

        private int driver;
        private int driven;
        private double pitch;
        private double center;


        public centerCalculatorGUI()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RunButtonClick(object sender, EventArgs e)// where we update the outputs
        {
            calc.UpdateCalculator(driver, driven, pitch, center);

            double[] centers = calc.CentersOptions();
            int[] lengths = calc.LengthOptions();

            int shortLen = lengths[0];
            int longLen = lengths[1];

            double shortCenter = centers[0];
            double longCenter = centers[1];

            ShortDistIndicator.Text = Convert.ToString(shortCenter);
            ShortLengthIndicator.Text = Convert.ToString(shortLen);
            LongDistIndicator.Text = Convert.ToString(longCenter);
            LongLengthIndicator.Text = Convert.ToString(longLen);
        }

        private void PitchValueChanged(object sender, EventArgs e)
        {
            if (PitchComboBox.Text != "")
            {
                pitch = InputValidator.GetPitch(PitchComboBox.Text);
                if (pitch == -1)
                {
                    InvalidPitchInput.Visible = true;
                }
                else
                {
                    InvalidPitchInput.Visible = false;
                }
            }

            else
            {
                InvalidPitchInput.Visible = false;
            }

        }

        private void DrivingSprocketChainged(object sender, EventArgs e)
        {
            UpdateRatioAndSprockets();
        }

        private void DrivenSprocketChainged(object sender, EventArgs e)
        {
            UpdateRatioAndSprockets();
        }

        private void UpdateRatioAndSprockets()
        {
            driven = (int)DrivenSprocketSelector.Value;
            driver = (int)DriveSprocketSelector.Value;

            decimal ratio = DrivenSprocketSelector.Value / DriveSprocketSelector.Value;

            ratio = Math.Round(ratio, 4, MidpointRounding.AwayFromZero);

            string output = Convert.ToString(ratio);

            TorqueRatioIndicator.Text = output;
        }

        private void DesierdCenterChanged(object sender, EventArgs e)
        {
            if (CenterDistEntry.Text != "")
            {
                center = InputValidator.GetCenter(CenterDistEntry.Text);

                if (center == -1)
                {
                    InvalidCenterInput.Visible = true;
                }

                else
                {
                    InvalidCenterInput.Visible = false;
                }
            }
            else
            {
                InvalidCenterInput.Visible = false;
            }
            
        }
    }
}
