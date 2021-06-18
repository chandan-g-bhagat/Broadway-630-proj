using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;

namespace SchoolManagement.UI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            SpeechRecognizer sr = new SpeechRecognizer();
            sr.SpeechRecognized += Sr_SpeechRecognized;
        }

        private void Sr_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
        }

        private void Sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}