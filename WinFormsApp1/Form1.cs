using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            int x = 100;
            int y = 100;
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                Button button = new Button()
                {
                    Location= new Point(x, y),  
                    Text = $"{i+1}",
                    Height= 50,
                    Width= 100,
                    BackColor= Color.White
                };
                if (i <= 3) Location = new Point(x * i, y);
                else if (i >= 3 && i <=6) Location = new Point(x * i, y);
                button.Click += MB;
                this.Controls.Add(button);
            }
        }
        private int POS(int pos, int i)
        {
            if (i == 3 || i == 6 || i == 9)
            {
                i = 0;
                pos *= i;
            }
            return pos;
        }
        private void MB (object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Vova")
            {
                label2.Text = "Matvey";
            }
            else
            {
                label2.Text = "Vova";
            }
        }
        private bool sw = false;
        //private void button1_Click(object sender, EventArgs e)
        //{

        //    if (sw == false && MessageBox.Show("Ты гей?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    {
        //        label4.Text = "GEY";
        //        sw = true;
        //    }

        //    else if (sw)
        //    {
        //        MessageBox.Show("Не стесняйтя что ты GEY", "Warning!", MessageBoxButtons.OK);
        //        MessageBox.Show("Молодец, что не стясняешся!", "Warning!", MessageBoxButtons.OK);
        //        MessageBox.Show("Молодцы сосут концы ;) xD", "Warning!", MessageBoxButtons.OK);
        //    }
        //    else if (!sw)
        //    {
        //        if (MessageBox.Show("Точно?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
        //        {
        //            label4.Text = "GEY";
        //        }
        //        else
        //        {
        //            if (MessageBox.Show("Гея ответ!", "Question", MessageBoxButtons.OK) == DialogResult.OK)
        //            {
        //                label4.Text = "GEY";
        //            }
        //        }
        //        sw = true;
        //    }
        //    //button1.Location = new Point(random.Next(0,800-button1.Size.Height), random.Next(0,500 - button1.Size.Width));
        //}
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}