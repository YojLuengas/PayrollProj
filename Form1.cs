namespace PayrollProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DTR Obj = new DTR();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Payroll Obj = new Payroll();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Violet;  // Set the label background to blue
            label2.ForeColor = Color.White; // Set the label text to a contrasting color
            label2.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent; // Reset the background color
            label2.ForeColor = Color.Black;       // Reset the text color to the default
            label2.Cursor = Cursors.Default;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Violet;
            label1.ForeColor = Color.White;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Cursor = Cursors.Default;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Violet;
            label3.ForeColor = Color.White;
            label3.Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Cursor = Cursors.Default;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.Violet;
            label5.ForeColor = Color.White;
            label5.Cursor = Cursors.Hand;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Black;
            label5.Cursor = Cursors.Default;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.Violet;
            label6.ForeColor = Color.White;
            label6.Cursor = Cursors.Hand;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Black;
            label6.Cursor = Cursors.Default;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DTR Obj = new DTR();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Payroll Obj = new Payroll();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
