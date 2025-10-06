using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Basic_Text_Diary_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            /* Define Variables */

            string Title = textBoxTitle.Text;
            string Date = textBoxDate.Text;
            string Entry = textBoxEntry.Text;
            string fileName = $"{Title}.txt";

            /* Create .txt file and store it*/

            File.Create(fileName).Close();
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("Entry Title: " + Title);
                sw.WriteLine("\n");
                sw.WriteLine("Entry Date: " + Date);
                sw.WriteLine("\n");
                sw.WriteLine(Entry);

            }

            /* Hide textboxes and labels */

            buttonSubmit.Text = "Submitted";
            buttonSubmit.Enabled = false;
            labelTitle.Hide();
            labelDate.Hide();
            labelEntry.Hide();
            textBoxTitle.Hide();
            textBoxDate.Hide();
            textBoxEntry.Hide();

            /* Reveal Ending Remarks */

            labelEndStatement.Show();
        }
    }
}
