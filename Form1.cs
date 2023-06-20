namespace Array
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int index = 0;
        public Form1()
        {
            InitializeComponent();

            for (int j = 0; j < 4; j++) {
                for (int i = 0; i < 4; i++) {
                
                    buttonArr1[i, j] = new Button();
                    this.buttonArr1[i, j].Enabled = false;
                    buttonArr1[i, j].Location = new System.Drawing.Point(100 * i, 100 * j);
                    this.buttonArr1[i, j].Name = "button" + i + j;
                    this.buttonArr1[i, j].Size = new System.Drawing.Size(100, 100);
                    this.buttonArr1[i, j].TabIndex = index;
                    this.buttonArr1[i, j].Text = (index + 1) + "";
                    this.buttonArr1[i, j].UseVisualStyleBackColor = true;
                    this.buttonArr1[i, j].Click += button1_Click;
                    this.buttonArr1[i, j].BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255), random.Next(255));
                    this.Controls.Add(this.buttonArr1[i, j]);
                    index++;

                }
            }

            this.Text = buttonArr1.GetLength(0) + "  -  " + buttonArr1.GetLength(1);

            for (int j = 0; j < 4; j++) {
                for (int i = 0; i < 4; i++) {
                    this.buttonArr1[i, j].Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = sender as Button;
            if (temp != null)
            {
                temp.Enabled = false;
            }
        }


    }
}
