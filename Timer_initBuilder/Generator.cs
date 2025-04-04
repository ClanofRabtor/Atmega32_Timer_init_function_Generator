using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_initBuilder
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string str = null;
            try
            {
                string Timer = cbxTimerSelect.Text;
                int Prescaler = Convert.ToInt32(cbxPrescaler.Text);
                int Mode = Convert.ToInt32(txtMode.Text);
                int OCRA = txtOCRA.Text == "" ? 0 : Convert.ToInt32(txtOCRA.Text);
                int OCRB = txtOCRB.Text == "" ? 0 : Convert.ToInt32(txtOCRB.Text);
                int COMA = comMode[cbxCOMA.Text];
                int COMB = comMode[cbxCOMB.Text];

                str = C_func.Generate(Timer, Prescaler, Mode, OCRA, COMA, OCRB, COMB);
                txt_output.Text = str;
            }
            catch (FormatException)
            {
                MessageBox.Show("Richtige Werte du mongo!", "Fehler!");
            }

        }

        private Dictionary<string, int> comMode = new Dictionary<string, int>
            {
                {"", 0},
                { "NON-Inverting" ,2 },
                { "Inverting" , 3 }
            };

    }
}
