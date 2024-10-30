using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PayrollProj;

public partial class Employee : Form
{
    public Employee()
    {
        InitializeComponent();
        ShowEmployee();
    }

    
   SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-19LRU3C\SQLEXPRESS02;Initial Catalog=Payroll;Integrated Security=True;Encrypt=False");
    
    
    private void Clear()
    {
        EmpNameTb.Text = "";
        EmpContTb.Text = "";
        EmpGenCb.SelectedIndex = -1;
        EmpAddTb.Text = "";
        EmpSalTb.Text = "";
        Key = 0;
    }

    private void ShowEmployee()
    {
        Con.Open();
        string Query = "select * from EmployeeTbl";
        SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
        SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
        var ds = new DataSet();
        sda.Fill(ds);
        EmpDGV.DataSource = ds.Tables[0];
        Con.Close();
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        if (EmpNameTb.Text == "" || EmpContTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "")
        {
            MessageBox.Show("Missing Information");
        }
        else
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into EmployeeTbl(EmpName, EmpCont, EmpGen, EmpAdd, EmpDOB, EmpBasSal)values(@EN,@EC,@EG,@EA,@ED,@EBS)", Con);
                cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@EC", EmpContTb.Text);
                cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Saved");
                Con.Close();
                ShowEmployee();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    int Key = 0;
    private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

        EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
        EmpGenCb.SelectedItem = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
        EmpDOB.Value = Convert.ToDateTime(EmpDGV.SelectedRows[0].Cells[3].Value);
        EmpContTb.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
        EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
        EmpSalTb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();

        if (EmpNameTb.Text == "")
        {
            Key = 0;
        }
        else
        {
            Key = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
        }
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        if (EmpNameTb.Text == "" || EmpContTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "")
        {
            MessageBox.Show("Missing Information");
        }
        else
        {
            try
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand("Update EmployeeTbl Set EmpName=@EN, EmpCont=@EC, EmpGen=@EG, EmpAdd=@EA, EmpDOB=@ED, EmpBasSal=@EBS where EmpId=@EmpKey ", Con);
                cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@EC", EmpContTb.Text);
                cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                cmd.Parameters.AddWithValue("@EmpKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Updated");
                Con.Close();
                ShowEmployee();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
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
                SqlCommand cmd = new SqlCommand("Delete from EmployeeTbl where EmpId = @EmpKey", Con);

                cmd.Parameters.AddWithValue("@EmpKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted");
                Con.Close();
                ShowEmployee();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

    private void Employee_Load(object sender, EventArgs e)
    {

    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        Form1 Obj = new Form1();
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

    private void label1_Click(object sender, EventArgs e)
    {
        Form1 Obj = new Form1();
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
}

