using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuengForm
{
    public partial class Customize : Form
    {

        //private QueuingForm queuengForm;
        
        public Customize()
        {
            InitializeComponent();
            //this.queuengForm = new QueuingForm();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Custom_P.Text)) 
            {
                MessageBox.Show("","Invalid Blank input");
                return;
            }
            else
            {
                //CashierClass.SetNewNumberInQueue(queuengForm.UpdateLabel(textBox_Custom_P.Text.ToString()));
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {

        }

        private void Customize_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_Custom_P_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
