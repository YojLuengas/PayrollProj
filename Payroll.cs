using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayrollProj
{
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
            GetEmployees();
            PopulateMonthYearComboBox();
            GetAttendance();
            GetBonus();
            ShowSalary();

        }
        int Key = 0;

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-19LRU3C\SQLEXPRESS02;Initial Catalog=Payroll;Integrated Security=True;Encrypt=False");
        private void Clear()
        {
            EmpNameTb.Text = "";
            AbsentTb.Text = "";
            PresentTb.Text = "";
            ExcuseTb.Text = "";
            // TimeInPicker.Value = DateTime.Now;
            // TimeOutPicker.Value = DateTime.Now;
            // Key = 0;
        }
        private void ShowSalary()
        {
            Con.Open();
            string Query = "SELECT * FROM SalaryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalaryDGV.DataSource = ds.Tables[0];


            /*foreach (DataGridViewRow row in SalaryDGV.Rows)
            {
                if (row.Cells["SalPeriod"].Value != DBNull.Value) // Optionally format Period to show day-month-year if needed (assuming it is displayed in the DataGridView)
                {
                    DateTime periodDate = Convert.ToDateTime(row.Cells["SalPeriod"].Value);
                    row.Cells["SalPeriod"].Value = periodDate.ToString("MM-dd-yyyy");  // Show the day, month, and year
                }
            }*/

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

        private void GetBonus()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from Bonustbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BName", typeof(String));
            dt.Load(Rdr);
            BonusIdCb.ValueMember = "BName";
            BonusIdCb.DataSource = dt;
            Con.Close();
        }



        private void GetAttendance()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from DTRtbl Where EmpId=" + EmpIdCb.SelectedValue.ToString() + " ", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AttNum", typeof(int));
            dt.Load(Rdr);
            AttNumCb.ValueMember = "AttNum";
            AttNumCb.DataSource = dt;
            Con.Close();
        }

        private void getAttendanceData()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string Query = "SELECT DayPres, DayAbs, DayExcuse, TimeIn, TimeOut, Period FROM DTRTbl WHERE EmpId = " + EmpIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            double totalHoursWorked = 0;
            int totalPresentDays = 0;
            int totalAbsentDays = 0;
            int totalExcuseDays = 0;

            HashSet<string> uniquePeriods = new HashSet<string>(); // Dictionary to track unique Periods for stacking attendance values
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DateTime timeIn = Convert.ToDateTime(dr["TimeIn"]);
                    DateTime timeOut = Convert.ToDateTime(dr["TimeOut"]);
                    TimeSpan hoursWorked = timeOut - timeIn; // Calculate hours worked for each record
                    totalHoursWorked += hoursWorked.TotalHours;  // Sum hours regardless of the Period
                    string period = Convert.ToDateTime(dr["Period"]).ToString("MM-dd-yyyy");
                    if (!uniquePeriods.Contains(period))
                    {
                        uniquePeriods.Add(period);  // Mark this period as processed
                        totalPresentDays += Convert.ToInt32(dr["DayPres"]);
                        totalAbsentDays += Convert.ToInt32(dr["DayAbs"]);
                        totalExcuseDays += Convert.ToInt32(dr["DayExcuse"]);
                    }
                }
            }
            PresentTb.Text = totalPresentDays.ToString();
            AbsentTb.Text = totalAbsentDays.ToString();
            ExcuseTb.Text = totalExcuseDays.ToString();
            HoursWorkedTb.Text = totalHoursWorked.ToString("F2"); // Display total hours worked in text box 


            Con.Close();
        }


        private void getEmployeeNamee()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string Query = "select * from EmployeeTbl where EmpId= " + EmpIdCb.SelectedValue.ToString() + " ";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmpNameTb.Text = dr["EmpName"].ToString();
                    BaseSalaryTb.Text = dr["EmpBasSal"].ToString();
                }
            }
            Con.Close();
        }



        private void getBonusAmt()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            string Query = "select * from BonusTbl where BName='" + BonusIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BonusTb.Text = dr["BAmt"].ToString();
                    BonusTb.Text = dr["BAmt"].ToString();
                    BonusId2.Text = dr["BId"].ToString();
                }
            }
            Con.Close();
        }
        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getEmployeeNamee();
            GetAttendance();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BonusIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getBonusAmt();
        }

        private void AttNumCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getAttendanceData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int DailyBase = 0, Total = 0, Pres = 0, Abs = 0, Excuse = 0;
        double GrdTot = 0, TotTax = 0;
        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            if (BaseSalaryTb.Text == "" || BonusTb.Text == "")
            {
                MessageBox.Show("Select The Employee");
            }
            else
            {
                // Retrieve the base salary and calculate hourly wage
                double baseSalary = Convert.ToDouble(BaseSalaryTb.Text);
                double hourlyRate = baseSalary / (28 * 8);  // Assuming 28 workdays and 8 hours a day
                double totalHoursWorked = Convert.ToDouble(HoursWorkedTb.Text); // Get total hours worked from the attendance data
                double totalSalary = hourlyRate * totalHoursWorked; // Calculate total salary based on hours worked

                // Calculate the tax (16%)
                double tax = totalSalary * 0.16;
                TotTax = totalSalary - tax;

                // Get absent days and compute deduction (using the daily base salary)
                int absentDays = Convert.ToInt32(AbsentTb.Text);
                double dailySalary = baseSalary / 28; // Calculate daily salary based on 28 workdays in a month
                double deductionAmount = absentDays * dailySalary;  // Deduct based on daily salary
                



                // Calculate the final salary after applying the deduction
                GrdTot = TotTax + Convert.ToDouble(BonusTb.Text) - deductionAmount;  // Subtract deduction from total salary

                // Display the calculated salary
                BalanceTb.Text = "P " + GrdTot.ToString("F2"); // Display the final balance after deduction
            }
        }




        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresentTb.Text == "" || AbsentTb.Text == "" || ExcuseTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    // Insert salary record
                    SqlCommand cmd = new SqlCommand("INSERT INTO SalaryTbl (EmpId, BId, AttNum, EmpName, EmpBasSal, EmpBonus, EmpTax, EmpBalance, SalPeriod) OUTPUT INSERTED.SalNum VALUES (@EI, @BI, @AN, @EN, @EBS, @EBon, @ETax, @EBal, @SPer)", Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@BI", BonusId2.Text);
                    cmd.Parameters.AddWithValue("@AN", AttNumCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EBS", BaseSalaryTb.Text);
                    cmd.Parameters.AddWithValue("@EBon", BonusTb.Text);
                    cmd.Parameters.AddWithValue("@ETax", TotTax);
                    cmd.Parameters.AddWithValue("@EBal", GrdTot);
                    cmd.Parameters.AddWithValue("@SPer", MonthYearCb.SelectedItem.ToString());

                    int salNum = (int)cmd.ExecuteScalar(); // Retrieve the SalNum of the newly inserted record

                    // Insert deduction record using Sal
                    double deductionAmount = 0;
                    if (double.TryParse(BaseSalaryTb.Text, out double baseSalary) && int.TryParse(AbsentTb.Text, out int absentDays))
                    {
                        double dailySalary = baseSalary / 28; // Calculate daily salary based on 28 workdays in a month
                        deductionAmount = absentDays * dailySalary; // Deduction based on absent days

                        SqlCommand deductionCmd = new SqlCommand("INSERT INTO DeductTbl (SalNum, Deduction, DeductPeriod) VALUES (@SalNum, @Deduction, @DeductPeriod)", Con);
                        deductionCmd.Parameters.AddWithValue("@SalNum", salNum);
                        deductionCmd.Parameters.AddWithValue("@Deduction", deductionAmount);
                        deductionCmd.Parameters.AddWithValue("@DeductPeriod", MonthYearCb.SelectedItem.ToString());
                        deductionCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payroll Saved");
                    Con.Close();
                    Clear();
                    ShowSalary();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SalaryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 500, 800);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            string EmpId = SalaryDGV.SelectedRows[0].Cells[1].Value.ToString();
            string EmpName = SalaryDGV.SelectedRows[0].Cells[4].Value.ToString();
            string BasSal = SalaryDGV.SelectedRows[0].Cells[5].Value.ToString();
            string Bonus = SalaryDGV.SelectedRows[0].Cells[6].Value.ToString();
            string Tax = SalaryDGV.SelectedRows[0].Cells[7].Value.ToString();
            string Balance = SalaryDGV.SelectedRows[0].Cells[8].Value.ToString();
            string Period = SalaryDGV.SelectedRows[0].Cells[9].Value.ToString();
           // string Bawas = SalaryDGV.SelectedRows[0].Cells[10].Value.ToString();


            //Initialize totals for stacking attendance and summing hours worked
            double totalHoursWorked = 0;
            int totalPresentDays = 0;
            int totalAbsentDays = 0;
            int totalExcuseDays = 0;
            HashSet<string> uniquePeriods = new HashSet<string>(); // Dictionary to track unique Periods for stacking attendance values
            Con.Open();
            string attendanceQuery = "SELECT DayPres, DayAbs, DayExcuse, TimeIn, TimeOut, Period FROM DTRTbl WHERE EmpId = " + EmpId;
            SqlCommand cmd = new SqlCommand(attendanceQuery, Con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime timeIn = Convert.ToDateTime(reader["TimeIn"]);
                DateTime timeOut = Convert.ToDateTime(reader["TimeOut"]);
                TimeSpan hoursWorked = timeOut - timeIn;
                totalHoursWorked += hoursWorked.TotalHours;  // Sum hours regardless of the Period
                string period = Convert.ToDateTime(reader["Period"]).ToString("MM-dd-yyyy"); // Use the Period column as the unique identifier for the day (e.g., Period: MM-dd-yyyy)
                if (!uniquePeriods.Contains(period))
                {
                    uniquePeriods.Add(period); // Stack Present, Absent, and Excuse days for distinct periods only
                    totalPresentDays += Convert.ToInt32(reader["DayPres"]);
                    totalAbsentDays += Convert.ToInt32(reader["DayAbs"]);
                    totalExcuseDays += Convert.ToInt32(reader["DayExcuse"]);

                }
            }

            reader.Close();
            Con.Close();
            string formattedHoursWorked = totalHoursWorked.ToString("F2");





            double deductionAmount = 0;
            Con.Open();
            string deductionQuery = "SELECT Deduction FROM DeductTbl WHERE SalNum = @SalNum";
            SqlCommand deductionCmd = new SqlCommand(deductionQuery, Con);
            deductionCmd.Parameters.AddWithValue("@SalNum", SalaryDGV.SelectedRows[0].Cells[0].Value.ToString());
            object result = deductionCmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                deductionAmount = Convert.ToDouble(result);
            }
            Con.Close();



            e.Graphics.DrawString("Employee PaySlip", new Font("Arial", 18, FontStyle.Bold), Brushes.Blue, new Point(145, 45));
            e.Graphics.DrawString("Employee ID: " + EmpId, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("Employee Name: " + EmpName, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(250, 150));
            e.Graphics.DrawString("____________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(55, 170));
            e.Graphics.DrawString("No of days worked: " + totalPresentDays + "    No of applied leaves: " + totalAbsentDays + "   No of Paid leaves: " + totalExcuseDays, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("Hours Worked: " + formattedHoursWorked, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 230));
            e.Graphics.DrawString("Base Salary: ₱ " + BasSal, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 260));
            e.Graphics.DrawString("Bonus: ₱ " + Bonus, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 290));
            e.Graphics.DrawString("Tax: ₱ " + Tax, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("Deduction: ₱ " + deductionAmount, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 350));
            e.Graphics.DrawString("____________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(55, 430));
            e.Graphics.DrawString("Total: ₱ " + Balance, new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, new Point(50, 470));
            e.Graphics.DrawString("____________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(55, 490));
            e.Graphics.DrawString("Date: " + Period, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 520));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(50, 540));
        }

        private void PopulateMonthYearComboBox()
        {
            MonthYearCb.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 1; year <= currentYear + 1; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    string monthYear = $"{new DateTime(year, month, 1).ToString("MMMM")} 1-{daysInMonth} {year}";
                    MonthYearCb.Items.Add(monthYear);
                }
            }
            int currentMonth = DateTime.Now.Month;
            int daysInCurrentMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            string currentMonthYear = $"{DateTime.Now.ToString("MMMM")} 1-{daysInCurrentMonth} {currentYear}";
            MonthYearCb.SelectedItem = currentMonthYear;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
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

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (SalaryDGV.SelectedRows.Count > 0)
            {
                string empId = SalaryDGV.SelectedRows[0].Cells[1].Value.ToString();  // Employee ID or SalNum
                string salNum = SalaryDGV.SelectedRows[0].Cells[0].Value.ToString(); // Salary Number (assuming it's in the first column)

                try
                {
                    // Confirm deletion
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Open connection
                        Con.Open();

                        // Delete from DeductTbl using SalNum
                        string deleteDeductQuery = "DELETE FROM DeductTbl WHERE SalNum = @SalNum";
                        SqlCommand deductCmd = new SqlCommand(deleteDeductQuery, Con);
                        deductCmd.Parameters.AddWithValue("@SalNum", salNum);
                        deductCmd.ExecuteNonQuery();

                        // Delete from SalaryTbl using EmpId or SalNum
                        string deleteSalaryQuery = "DELETE FROM SalaryTbl WHERE SalNum = @SalNum";
                        SqlCommand salaryCmd = new SqlCommand(deleteSalaryQuery, Con);
                        salaryCmd.Parameters.AddWithValue("@SalNum", salNum);
                        salaryCmd.ExecuteNonQuery();
                        Con.Close();
                        ShowSalary();
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SalDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MonthYearCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedMonthYear = MonthYearCb.SelectedItem.ToString();
        }

        private void StoreDeduction(double deductionAmount)
        {
            try
            {
                // Open the database connection
                Con.Open();

                // Retrieve SalNum from SalaryTbl based on the selected employee and period
                string query = "SELECT SalNum FROM SalaryTbl WHERE EmpId = @EmpId AND SalPeriod = @SalPeriod";
                SqlCommand fetchSalNumCmd = new SqlCommand(query, Con);
                fetchSalNumCmd.Parameters.AddWithValue("@EmpId", EmpIdCb.SelectedValue.ToString());
                fetchSalNumCmd.Parameters.AddWithValue("@SalPeriod", MonthYearCb.SelectedItem.ToString());
                object result = fetchSalNumCmd.ExecuteScalar();

                if (result != null)
                {
                    int salNum = Convert.ToInt32(result);

                    // Insert into DeductTbl using SalNum
                    SqlCommand cmd = new SqlCommand("INSERT INTO DeductTbl (SalNum, Deduction, DeductPeriod) VALUES (@SalNum, @Deduction, @DeductPeriod)", Con);
                    cmd.Parameters.AddWithValue("@SalNum", salNum);
                    cmd.Parameters.AddWithValue("@Deduction", deductionAmount);
                    cmd.Parameters.AddWithValue("@DeductPeriod", MonthYearCb.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deduction stored successfully!");
                }
                else
                {
                    MessageBox.Show("Unable to find SalNum for the selected employee.");
                }

                // Close the connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
 }
 

