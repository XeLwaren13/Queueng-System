using System;
using System.Collections;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace QueuengForm
{

    public partial class CashierWindowQueueForm : Form
    {
        private QueuingForm queuingForm;

        public CashierWindowQueueForm(QueuingForm form)
        {
            InitializeComponent();
            this.queuingForm = form;
            this.startime();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listView_List.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listView_List.Items.Add(obj.ToString());
            }
        }

        private void startime()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(this.button_Refresh_Click);
            timer.Start();
        }

        private void SpeakText(string text, string prefix = "Customer ")
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.Volume = 100;
                synthesizer.Rate = 0;

                synthesizer.Speak(prefix);

                foreach (char character in text)
                {
                        synthesizer.Speak(character.ToString());
                }
            }
        }


        private void button_Refresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Next_Click(object sender, EventArgs e)
        {

            try
            {
                var nextItem = CashierClass.CashierQueue.Dequeue();

                if (queuingForm != null)
                {
                    queuingForm.LabelP10007.Text = nextItem.ToString();
                    SpeakText(queuingForm.LabelP10007.Text, "Attention Customer ");
                }

                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("The queue is empty!", "Invalid Operation");
                if (queuingForm != null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
            }

        }

        private void listView_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_NewNumber_Click(object sender, EventArgs e)
        {
            if (queuingForm != null)
            {
                queuingForm.GenerateNewNumber();

                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }
    }
}
