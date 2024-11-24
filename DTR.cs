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
    public partial class DTR : Form
    {
        public DTR()
        {
            InitializeComponent();
            ShowAttendance();
            GetEmployees();

            // Set the TimePicker to show time with AM/PM
            TimeInPicker.Format = DateTimePickerFormat.Custom;
            TimeInPicker.CustomFormat = "hh:mm tt";  // 12-hour format with AM/PM
            TimeInPicker.ShowUpDown = true;          // Removes the calendar and shows up/down control

            TimeOutPicker.Format = DateTimePickerFormat.Custom;
            TimeOutPicker.CustomFormat = "hh:mm tt";  // 12-hour format with AM/PM
            TimeOutPicker.ShowUpDown = true;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-19LRU3C\SQLEXPRESS02;Initial Catalog=Payroll;Integrated Security=True;Encrypt=False");
        private void Clear()
        {
            EmpNameTb.Text = "";
            
            TimeInPicker.Value = DateTime.Now;
            TimeOutPicker.Value = DateTime.Now;
            Key = 0;
        }
        private void ShowAttendance()
        {
            Con.Open();
            string Query = "select * from DTRTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDGV.DataSource = ds.Tables[0];

            // Format the TimeIn and TimeOut columns to show only the time with AM/PM
            foreach (DataGridViewRow row in AttendanceDGV.Rows)
            {
                if (row.Cells["TimeIn"].Value != DBNull.Value)
                {
                    DateTime timeIn = Convert.ToDateTime(row.Cells["TimeIn"].Value);
                    row.Cells["TimeIn"].Value = timeIn.ToString("hh:mm tt");
                }

                if (row.Cells["TimeOut"].Value != DBNull.Value)
                {
                    DateTime timeOut = Convert.ToDateTime(row.Cells["TimeOut"].Value);
                    row.Cells["TimeOut"].Value = timeOut.ToString("hh:mm tt");
                }

                // Set checkbox columns for Present, Absent, and Excused
                row.Cells["DayPres"].Value = (row.Cells["DayPres"].Value?.ToString() == "1");
                row.Cells["DayAbs"].Value = (row.Cells["DayAbs"].Value?.ToString() == "1");
                row.Cells["DayExcuse"].Value = (row.Cells["DayExcuse"].Value?.ToString() == "1");
                AttendanceDGV.Columns["TimeIn"].DefaultCellStyle.Format = "hh:mm tt";  // Example: 02:30 PM
                AttendanceDGV.Columns["TimeOut"].DefaultCellStyle.Format = "hh:mm tt"; // Example: 06:45 PM
            }

            Con.Close();
        }

        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employeetbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;
            Con.Close();
        }



        private void getEmployeeNamee()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string Query = $"select EmpName from EmployeeTbl where EmpId= {EmpIdCb.SelectedValue} ";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmpNameTb.Text = dr["EmpName"].ToString();
                }
            }
            Con.Close();
        }

        private void DTR_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void AttendanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = AttendanceDGV.Rows[e.RowIndex];

                // Set EmpId in ComboBox
                if (row.Cells["EmpId"].Value != null)
                {
                    EmpIdCb.SelectedValue = Convert.ToInt32(row.Cells["EmpId"].Value);
                }

                // Set EmpName TextBox
                EmpNameTb.Text = row.Cells["EmpName"].Value.ToString();

                // Set Present, Absent, and Excuse TextBoxes
                // Set the CheckBox values based on DataGridView
                PresentCb.Checked = row.Cells["DayPres"].Value != DBNull.Value && row.Cells["DayPres"].Value.ToString() == "1";
                AbsentCb.Checked = row.Cells["DayAbs"].Value != DBNull.Value && row.Cells["DayAbs"].Value.ToString() == "1";
                ExcuseCb.Checked = row.Cells["DayExcuse"].Value != DBNull.Value && row.Cells["DayExcuse"].Value.ToString() == "1";

                // Set TimeIn DateTimePicker (assuming TimeIn is a DateTime in the database)
                if (row.Cells["TimeIn"].Value != DBNull.Value) // Ensure valid TimeIn value
                {
                    DateTime timeIn = Convert.ToDateTime(row.Cells["TimeIn"].Value); // Cast to DateTime
                    TimeInPicker.Value = timeIn; // Set DateTimePicker with TimeIn
                }

                // Set TimeOut DateTimePicker (assuming TimeOut is a DateTime in the database)
                if (row.Cells["TimeOut"].Value != DBNull.Value) // Ensure valid TimeOut value
                {
                    DateTime timeOut = Convert.ToDateTime(row.Cells["TimeOut"].Value); // Cast to DateTime
                    TimeOutPicker.Value = timeOut; // Set DateTimePicker with TimeOut
                }

                // Set the Attendance Date
                if (row.Cells["Period"].Value != DBNull.Value) // Ensure valid Period value
                {
                    DateTime periodDate = Convert.ToDateTime(row.Cells["Period"].Value); // Convert to DateTime
                    AttDate.Text = periodDate.ToString("MM-dd-yyyy"); // Format the date
                }

                // Set Key for update and delete operations
                if (row.Cells["AttNum"].Value != null)
                {
                    Key = Convert.ToInt32(row.Cells["AttNum"].Value.ToString());
                }
            }
        }


        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getEmployeeNamee();
        }

        private double CalculateHoursWorked(DateTime timeIn, DateTime timeOut)
        {
            TimeSpan timeDifference = timeOut - timeIn;
            return timeDifference.TotalHours;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || !PresentCb.Checked && !AbsentCb.Checked && !ExcuseCb.Checked)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.ToString("MM-dd-yyyy");
                    DateTime timeIn = TimeInPicker.Value;
                    DateTime timeOut = TimeOutPicker.Value;
                    double hoursWorked = CalculateHoursWorked(timeIn, timeOut);

                    int present = PresentCb.Checked ? 1 : 0;
                    int absent = AbsentCb.Checked ? 1 : 0;
                    int excuse = ExcuseCb.Checked ? 1 : 0;

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DTRTbl(EmpId, EmpName, DayPres, DayAbs, DayExcuse, TimeIn, TimeOut, HoursWorked, Period)values(@EI,@EN,@DP,@DA,@DE,@TI,@TO,@HW,@Per)", Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", present);
                    cmd.Parameters.AddWithValue("@DA", absent);
                    cmd.Parameters.AddWithValue("@DE", excuse);
                    cmd.Parameters.AddWithValue("@TI", timeIn);
                    cmd.Parameters.AddWithValue("@TO", timeOut);
                    cmd.Parameters.AddWithValue("@HW", hoursWorked);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Attendance Saved");
                    Con.Close();
                    ShowAttendance();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || !PresentCb.Checked && !AbsentCb.Checked && !ExcuseCb.Checked)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.ToString("MM-dd-yyyy");
                    DateTime timeIn = TimeInPicker.Value;
                    DateTime timeOut = TimeOutPicker.Value;
                    double hoursWorked = CalculateHoursWorked(timeIn, timeOut);

                    int present = PresentCb.Checked ? 1 : 0;
                    int absent = AbsentCb.Checked ? 1 : 0;
                    int excuse = ExcuseCb.Checked ? 1 : 0;

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DTRTbl Set EmpId=@EI, EmpName=@EN, DayPres=@DP, DayAbs=@DA, DayExcuse=@DE, TimeIn=@TI, TimeOut=@TO, HoursWorked=@HW, Period=@Per where AttNum=@AttKey", Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", present);
                    cmd.Parameters.AddWithValue("@DA", absent);
                    cmd.Parameters.AddWithValue("@DE", excuse);
                    cmd.Parameters.AddWithValue("@TI", timeIn);
                    cmd.Parameters.AddWithValue("@TO", timeOut);
                    cmd.Parameters.AddWithValue("@HW", hoursWorked);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.Parameters.AddWithValue("@AttKey", Key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    ShowAttendance();
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
                    SqlCommand cmd = new SqlCommand("Delete from DTRTbl where AttNum = @AttKey", Con);

                    cmd.Parameters.AddWithValue("@AttKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Deleted");
                    Con.Close();
                    ShowAttendance();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
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
    }
}
