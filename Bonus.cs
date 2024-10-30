using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProj
{
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
            ShowBonus();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-19LRU3C\SQLEXPRESS02;Initial Catalog=Payroll;Integrated Security=True;Encrypt=False");
        private void Clear()
        {
            BNameTb.Text = "";
            BAmountTb.Text = "";


            Key = 0;
        }
        private void ShowBonus()
        {
            Con.Open();
            string Query = "select * from BonusTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BonusDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        int Key = 0;

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BonusTbl(BName, BAmt)values(@BN,@BA)", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Saved");
                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BonusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BNameTb.Text = BonusDGV.SelectedRows[0].Cells[1].Value.ToString();
            BAmountTb.Text = BonusDGV.SelectedRows[0].Cells[2].Value.ToString();


            if (BNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BonusDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update BonusTbl Set BName=@BN, BAmt=@BA where BId=@BKey", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Update");
                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from BonusTbl where BId = @BKey", Con);

                    cmd.Parameters.AddWithValue("@BKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Deleted");
                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Payroll Obj = new Payroll();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DTR Obj = new DTR();
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

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Violet;
            label2.ForeColor = Color.White;
            label2.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Cursor = Cursors.Default;
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

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void Bonus_Load(object sender, EventArgs e)
        {

        }
    }
}
