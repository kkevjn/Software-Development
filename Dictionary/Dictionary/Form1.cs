using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, float> studentDictionary = new Dictionary<string, float>();
        public void WaitTimer(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (studentDictionary.ContainsKey(nameText.Text))
            {
                userAlreadyExist.Visible = true;
                WaitTimer(2000);
                userAlreadyExist.Visible = false;
            }
            else if (String.IsNullOrEmpty(nameText.Text) || String.IsNullOrWhiteSpace(heightText.Text))
            {
                tryAgain.Visible = true;
                WaitTimer(2000);
                tryAgain.Visible = false;
            }
            else {
                studentDictionary.Add(nameText.Text, float.Parse(heightText.Text));
                label2.Visible = true;
                WaitTimer(2000);
                label2.Visible = false; 
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            bool keyExists = studentDictionary.ContainsKey(nameText.Text);
            if (keyExists)
            {
                studentDictionary.Remove(nameText.Text);
                label5.Visible = true;
            }
            else
            {
                userNotInDatabase.Visible = true;
                WaitTimer(2000);
                userNotInDatabase.Visible = false;
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //DISPLAY
            listBox1.Items.Clear(); //clear the listbox before displaying the values

            foreach (KeyValuePair<string, float> pair in studentDictionary)
            {
                listBox1.Items.Add($"{pair.Key} - {pair.Value} cm.");
            }

            label3.Visible = true;
            WaitTimer(2000);
            label3.Visible = false;

            //AVERAGE
            double averageHeight = 0;

            foreach (KeyValuePair<string, float> pair in studentDictionary)
            {
                averageHeight = averageHeight + pair.Value;
            }

            averageHeight = averageHeight / studentDictionary.Count;
            average.Text = averageHeight.ToString() + " cm";
            average.Visible = true;
        }

        private void userNotInDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
