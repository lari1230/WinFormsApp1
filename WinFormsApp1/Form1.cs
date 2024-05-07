using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            _ = Task.Run(async() => await ButtonLoc());
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 second = new Form2();
            second.FormClosed += secondFormClose;
            second.ShowDialog();
        }
        private void secondFormClose(object sender, EventArgs e)
        {
            this.Show();
            
        }
        public async Task ButtonLoc()
        {
            try
            {
                Random random = new Random();
                while (true)
                { 
                     button1.Location = new Point(random.Next(0, 750), random.Next(0, 450));
                     Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            
        }
    }
}