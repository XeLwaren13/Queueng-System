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

    public partial class QueuingForm : Form
    {

        private CashierClass cashier;
        private CashierWindowQueueForm cashierwindowqueform;

        public QueuingForm()
        {
            InitializeComponent();
            this.cashier = new CashierClass();
            this.cashierwindowqueform = new CashierWindowQueueForm(this);
        }

        public Label LabelP10007
        {
            get { return label_P10007; }
        }

        public void GenerateNewNumber()
        {
            string newNumber = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = newNumber;
            CashierClass.CashierQueue.Enqueue(newNumber);
        }

        private void OpenCashierWindow()
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm(this);
            cashierWindow.Show();
        }


        private void linkLabel_Click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateNewNumber();
        }

        public void label_P10007_Click(object sender, EventArgs e)
        {

        }

        private void label_PositionInQueue_Click(object sender, EventArgs e)
        {

        }

        public void QueuingForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            this.cashierwindowqueform.ShowDialog();
        }
    }
}
