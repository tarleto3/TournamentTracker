using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class Create_Prize_Form : Form
    {
        public Create_Prize_Form()
        {
            InitializeComponent();
        }

        private void TXT_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel();

                model.PlaceName = TXT_PlaceName.Text;
                model.PlaceNumber = Convert.ToInt32(TXT_PlaceNumber.Text);
                model.PrizeAmount = Convert.ToDecimal(TXT_PrizeAmount.Text);
                model.PrizePercentage = Convert.ToDouble(TXT_PrizePercent.Text);

                GlobalConfig.Connection.CreatePrize(model);

                TXT_PlaceName.Text = "";
                TXT_PlaceNumber.Text = "";
                TXT_PrizeAmount.Text = "0";
                TXT_PrizePercent.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidInt = int.TryParse(TXT_PlaceNumber.Text, out placeNumber);

            if (!placeNumberValidInt || placeNumber < 1)
            {
                output = false;
            }

            if (TXT_PlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(TXT_PrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(TXT_PrizePercent.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
