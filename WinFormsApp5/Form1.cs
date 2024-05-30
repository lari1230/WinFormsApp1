using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private static int numPage = 1;
        TabPage tabPage3 = new TabPage() { Text = "Редакт" + numPage };

        public Form1()
        {
            InitializeComponent();
        }
        List<TabPage> tabPages = new List<TabPage>();
        private string? filePath = null;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tab = CreateP(sender, e);
            this.tabControl1.SelectedTab = tab;

            tabControl1.Controls.Add(tab);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                filePath = openFileDialog.FileName;
                string str = File.ReadAllText(filePath);
                this.tabControl1.SelectedTab.Controls[0].Controls[3].Text = str;
                
                tabControl1.SelectedTab.Text = fileInfo.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath)) File.WriteAllText(filePath, tabControl1.SelectedTab.Controls[0].Controls[3].Text);
            else MessageBox.Show("This Path wasn't found!", "Warning", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 1)
            {
                tabControl1.Controls.Remove(this.tabControl1.SelectedTab);
            }
        }
        private TabPage CreateP(object sender, EventArgs e)
        {
            var tabPage = new TabPage();
            var tableLayoutPanel = new TableLayoutPanel();
            var button1 = new System.Windows.Forms.Button();
            var button2 = new System.Windows.Forms.Button();
            var button3 = new System.Windows.Forms.Button();
            var textBox1 = new System.Windows.Forms.TextBox();

            tabPage.Controls.Add(tableLayoutPanel);
            tabPage.Location = new Point(4, 24);
            tabPage.Name = "tabPage3";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new System.Drawing.Size(792, 422);
            tabPage.TabIndex = 1;
            tabPage.Text = "Редакт";
            tabPage.UseVisualStyleBackColor = true;

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel.Controls.Add(button1, 0, 3);
            tableLayoutPanel.Controls.Add(button2, 1, 3);
            tableLayoutPanel.Controls.Add(button3, 4, 3);
            tableLayoutPanel.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tableLayoutPanel.Size = new System.Drawing.Size(786, 416);
            tableLayoutPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(3, 370);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(151, 43);
            button1.TabIndex = 0;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(160, 370);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(151, 43);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = System.Windows.Forms.DockStyle.Fill;
            button3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(631, 370);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(152, 43);
            button3.TabIndex = 2;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            tableLayoutPanel.SetColumnSpan(textBox1, 5);
            textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.Location = new System.Drawing.Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            tableLayoutPanel.SetRowSpan(textBox1, 2);
            textBox1.Size = new System.Drawing.Size(780, 338);
            textBox1.TabIndex = 3;

            tabPage.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();

            return tabPage;
        }
    }
}
//public static class Create
//{
//    public static TabPage CreatePage(int indexPage)
//    {
//        var tabPage = new System.Windows.Forms.TabPage();
//        tabPage.SuspendLayout();

//        var tableLayoutPanel = CreateLayoutPanel();

//        tabPage.Controls.Add(tableLayoutPanel);
//        tabPage.Location = new System.Drawing.Point(4, 24);
//        tabPage.Name = "tabPage2";
//        tabPage.Padding = new System.Windows.Forms.Padding(3);
//        tabPage.Size = new System.Drawing.Size(792, 422);
//        tabPage.TabIndex = 1;
//        tabPage.Text = "Редакт";
//        tabPage.UseVisualStyleBackColor = true;

//        return tabPage;
//    }
//    public static TableLayoutPanel CreateLayoutPanel()
//    {
//        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
//        tableLayoutPanel.SuspendLayout();

//        tableLayoutPanel.ColumnCount = 5;
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        //tableLayoutPanel.Controls.Add(this.button1, 0, 3);
//        //tableLayoutPanel.Controls.Add(this.button2, 1, 3);
//        //tableLayoutPanel.Controls.Add(this.button3, 4, 3);
//        //tableLayoutPanel.Controls.Add(this.textBox1, 0, 0);
//        tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
//        tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
//        tableLayoutPanel.Name = "tableLayoutPanel1";
//        tableLayoutPanel.RowCount = 4;
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
//        tableLayoutPanel.Size = new System.Drawing.Size(786, 416);
//        tableLayoutPanel.TabIndex = 0;

//        var textBox = CreateTextBox();
//        tableLayoutPanel.SetColumnSpan(textBox, 5);
//        tableLayoutPanel.SetRowSpan(textBox, 2);

//        return tableLayoutPanel;
//    }
//    public static Button CreateButton(string nameButton)
//    {
//        Button button = new Button();
//        button.Dock = System.Windows.Forms.DockStyle.Fill;
//        button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        button.Name = "button1";
//        button.TabIndex = 0;
//        button.Text = nameButton;
//        button.UseVisualStyleBackColor = true;

//        return button;
//    }
//    public static TextBox CreateTextBox()
//    {
//        TextBox textBox = new TextBox();
//        textBox.Dock = System.Windows.Forms.DockStyle.Fill;
//        textBox.Location = new System.Drawing.Point(3, 3);
//        textBox.Multiline = true;
//        textBox.Name = "textBox1";
//        textBox.Size = new System.Drawing.Size(780, 338);
//        textBox.TabIndex = 3;

//        return textBox;
//    }
//    public static TabPage CreateP(object sender, EventArgs e)
//    {
//        var tabPage = new TabPage();
//        var tableLayoutPanel = new TableLayoutPanel();
//        var button1 = new Button();
//        var button2 = new Button();
//        var button3 = new Button();
//        var textBox1 = new TextBox();

//        tabPage.Controls.Add(tableLayoutPanel);
//        tabPage.Location = new Point(4, 24);
//        tabPage.Name = "tabPage3";
//        tabPage.Padding = new Padding(3);
//        tabPage.Size = new System.Drawing.Size(792, 422);
//        tabPage.TabIndex = 1;
//        tabPage.Text = "Редакт";
//        tabPage.UseVisualStyleBackColor = true;

//        // 
//        // tableLayoutPanel1
//        // 
//        tableLayoutPanel.ColumnCount = 5;
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
//        tableLayoutPanel.Controls.Add(button1, 0, 3);
//        tableLayoutPanel.Controls.Add(button2, 1, 3);
//        tableLayoutPanel.Controls.Add(button3, 4, 3);
//        tableLayoutPanel.Controls.Add(textBox1, 0, 0);
//        tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
//        tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
//        tableLayoutPanel.Name = "tableLayoutPanel1";
//        tableLayoutPanel.RowCount = 4;
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
//        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
//        tableLayoutPanel.Size = new System.Drawing.Size(786, 416);
//        tableLayoutPanel.TabIndex = 0;
//        // 
//        // button1
//        // 
//        button1.Dock = System.Windows.Forms.DockStyle.Fill;
//        button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        button1.Location = new System.Drawing.Point(3, 370);
//        button1.Name = "button1";
//        button1.Size = new System.Drawing.Size(151, 43);
//        button1.TabIndex = 0;
//        button1.Text = "File";
//        button1.UseVisualStyleBackColor = true;
//        button1.Click += new System.EventHandler(Form1.button1_Click(sender, e));
//        // 
//        // button2
//        // 
//        button2.Dock = System.Windows.Forms.DockStyle.Fill;
//        button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        button2.Location = new System.Drawing.Point(160, 370);
//        button2.Name = "button2";
//        button2.Size = new System.Drawing.Size(151, 43);
//        button2.TabIndex = 1;
//        button2.Text = "Save";
//        button2.UseVisualStyleBackColor = true;
//        // 
//        // button3
//        // 
//        button3.Dock = System.Windows.Forms.DockStyle.Fill;
//        button3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        button3.Location = new System.Drawing.Point(631, 370);
//        button3.Name = "button3";
//        button3.Size = new System.Drawing.Size(152, 43);
//        button3.TabIndex = 2;
//        button3.Text = "Close";
//        button3.UseVisualStyleBackColor = true;
//        //button3.Click += Form1.button3_Click();
//        // 
//        // textBox1
//        // 
//        tableLayoutPanel.SetColumnSpan(textBox1, 5);
//        textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
//        textBox1.Location = new System.Drawing.Point(3, 3);
//        textBox1.Multiline = true;
//        textBox1.Name = "textBox1";
//        tableLayoutPanel.SetRowSpan(textBox1, 2);
//        textBox1.Size = new System.Drawing.Size(780, 338);
//        textBox1.TabIndex = 3;

//        tabPage.ResumeLayout(false);
//        tableLayoutPanel.ResumeLayout(false);
//        tableLayoutPanel.PerformLayout();

//        return tabPage;
//    }
//}
//}