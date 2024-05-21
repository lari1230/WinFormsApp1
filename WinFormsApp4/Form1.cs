namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> picturesPath = new List<string>();

        

        private void button1_Click(object sender, EventArgs e)
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
            if (listBox1.Items.Count > 0 && listBox1.SelectedIndex != 0) pictureBox1.Image = Image.FromFile(picturesPath[listBox1.SelectedIndex]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (picturesPath.Count > 0) pictureBox1.Image = Image.FromFile(picturesPath[listBox1.SelectedIndex - 1]);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (picturesPath.Count != listBox1.SelectedIndex) pictureBox1.Image = Image.FromFile(picturesPath[listBox1.SelectedIndex + 1]);
        }
    }
}