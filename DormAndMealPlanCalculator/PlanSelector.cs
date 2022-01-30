using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlanCalculator
{
    public partial class PlanSelector : Form
    {
        public PlanSelector()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            TotalCharges charges = new TotalCharges();
            
            if (radioButtonAllenHall.Checked)
            {
                string allenCharge = "Allen Hall: $1500";
                charges.listBoxTotalCharges.Items.Add(allenCharge);
                
                
            }
            if (radioButtonPikeHall.Checked)
            {
                string pikeCharge = "Pike Hall: $1,600";
                charges.listBoxTotalCharges.Items.Add(pikeCharge);
            }

            if (radioButtonFarthingHall.Checked)
            {
                string farthingCharge = "Farthing Hall: $1800";
                charges.listBoxTotalCharges.Items.Add(farthingCharge);  
            }

            if (radioButtonUniSuites.Checked)
            {
                string uniSuitesCharge = "University Suites: $2,500";
                charges.listBoxTotalCharges.Items.Add(uniSuitesCharge);
            }
                
        charges.ShowDialog();


        }




    }
}
