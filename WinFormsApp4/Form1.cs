using System.Drawing.Drawing2D;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> picturesPath = new List<string>();

        private int elemIndex = 0;
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(dialog.SelectedPath);
                listBox1.Items.Clear(); 
                //listBox1.DataSource = directoryInfo.GetFiles();
                var items = directoryInfo.GetFiles();
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].Extension == ".jpg" || items[i].Extension == ".png" || items[i].Extension == ".jpeg")
                    {
                        listBox1.Items.Add(items[i].Name);
                        picturesPath.Add(items[i].FullName);
                    }
                }
                trackBar1.Maximum = listBox1.Items.Count-1;
                trackBar1.Visible = true;
                progressBar1.Maximum = listBox1.Items.Count-1;
                progressBar1.Visible = true;
            }
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "ImageFiles|.png;*.jpg;*.jpeg;";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(ofd.FileName);
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                SetPictureByIndex(listBox1.SelectedIndex);
                trackBar1.Value = listBox1.SelectedIndex;
                elemIndex = listBox1.SelectedIndex;
                progressBar1.Value = listBox1.SelectedIndex;
            }
        }
        private void buttonPrevios_Click(object sender, EventArgs e)
        {
            if (picturesPath.Count != 0)
            {
                elemIndex = elemIndex - 1 < 0 ? picturesPath.Count - 1 : elemIndex - 1;
                SetPictureByIndex(elemIndex);
                trackBar1.Value = elemIndex;
                progressBar1.Value = elemIndex;
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("asdf");
            if (picturesPath.Count != 0)
            {
                elemIndex = elemIndex + 1 >= picturesPath.Count ? 0 : elemIndex + 1;
                SetPictureByIndex(elemIndex);
                trackBar1.Value = elemIndex;
                progressBar1.Value = elemIndex;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer1.Enabled ? false : true;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(picturesPath[trackBar1.Value]);
            progressBar1.Value = trackBar1.Value;
        }
        private void SetPictureByIndex(int index)
        {
            pictureBox1.Image = Image.FromFile(picturesPath[index]);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonNext_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Иди Нахуй", "Пидр");
        }
    }
}