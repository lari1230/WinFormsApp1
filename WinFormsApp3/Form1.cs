using System;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime time1 = DateTime.Parse(textBox1.Text);
            //DateTime time2 = DateTime.Parse(textBox2.Text);

            //var result = time1 - time2;
            //label1.Text = result.Days.ToString() + " Days";
            label1.Text = "";
            if (checkBox1.Checked)
            {
                label1.Text += checkBox1.Text + ',';
            }
            if (checkBox2.Checked)
            {
                label1.Text += checkBox2.Text + ',';
            }
            if (checkBox3.Checked)
            {
                label1.Text += checkBox3.Text + ',';
            }
            if (checkBox4.Checked)
            {
                label1.Text += checkBox4.Text + ',';
            }
            if (!String.IsNullOrEmpty(label1.Text)) label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);


        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            label2.Text = radioButton.Text;
        }


    }
}