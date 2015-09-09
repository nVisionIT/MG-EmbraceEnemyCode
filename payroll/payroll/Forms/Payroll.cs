using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace payroll
{

    public partial class Payroll : Form
    {
        private Admin admin;
        private Payrollsss payroll;
        private AttendanceReport attendaceReport;
        private Counts counts;
        // REVIEW: MOOAS GANI – 5 – DO NOT HARD CODE SQL CONNECTION STRINGS. CHANGE TO PULL FROM APP.CONFIG
        private SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=FP_SAMPLE;Integrated Security=True");
        public Payroll()
        {
            InitializeComponent();
            admin = new Admin();
            payroll = new Payrollsss();
            counts = new Counts();
            attendaceReport = new AttendanceReport();
        }

         DataTable dbdataset;

        private void GenerateID()
        {
            string newID;
            admin.GetCountPayroll(counts);
            if (Convert.ToInt32(counts.Countss) == 0)
            {
                newID = "PAYROLL-10001";
                payroll.PayrollID = newID;
            }
            else
            {
                admin.GetLastIDPayroll(counts);
                string id = counts.LastID.Substring(8, 5);
                int increment = Convert.ToInt32(id) + 1;
                newID = "PAYROLL-" + increment.ToString();
                payroll.PayrollID = newID;
            }
        }
        private void GenerateIDs()
        {
            string newID;
            admin.GetCountAttendanceReport(counts);
            if (Convert.ToInt32(counts.Countss) == 0)
            {
                newID = "ATTENDANCEREPORT-10001";
                attendaceReport.AttendanceReportNO = newID;
            }
            else
            {
                admin.GetLastIDAttendanceReport(counts);
                string id = counts.LastID.Substring(17, 5);
                int increment = Convert.ToInt32(id) + 1;
                newID = "ATTENDANCEREPORT-" + increment.ToString();
                attendaceReport.AttendanceReportNO = newID;
            }
        }
        private void buttonCompute_Click(object sender, EventArgs e)
        {
            #region Attendance Report
            string attendanceReportsStart;
            string attendanceReportsEnd;
            string periodsss;
            string[] ID;
            string[] IDs;
            int[] TotalHoursA;
            int[] TotalLateA;
            int[] TotalHours12;
            int[] TotalLate12;
            int[] totalabsent;
            int[] total;
            int[] total2;
            int[] totalLateAndAbsent;
            int[] totalWork;
            int[] leave;            
            attendanceReportsStart = dateTimePickerReportStart.Value.ToShortDateString();
            attendanceReportsEnd = dateTimePickerReportEnd.Value.ToShortDateString();
            periodsss = attendanceReportsStart + "-" + attendanceReportsEnd;
            if(admin.CheckPayrollPeriod(periodsss))
            {
                MessageBox.Show("You HaveAlready Generated that Period");
                dateTimePickerReportStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dateTimePickerReportEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dateTimePickerPaydate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                return;
            }
            else
            {

                admin.AttendanceReport(attendanceReportsStart, attendanceReportsEnd);
                admin.AttendanceReports(attendanceReportsStart, attendanceReportsEnd);
                admin.AttendanceReportLeave(attendanceReportsStart, attendanceReportsEnd);
                dataGridViewAttendanceReport.DataSource = admin.DataSet.Tables["EmployeeAttendanceReport"];
                dataGridViewAttendance123.DataSource = admin.DataSet.Tables["EmployeeAttendanceReports"];
                dataGridView12.DataSource = admin.Dt.Tables["LeaveEmployee"];
                dataGridViewLeave.DataSource = admin.DataSet.Tables["EmployeeAttendanceLeave"];
                dataGridViewLeave.AllowUserToAddRows = false;
                dataGridView12.AllowUserToAddRows = false;
                dataGridViewAttendanceReport.AllowUserToAddRows = false;
                dataGridViewAttendance123.AllowUserToAddRows = false;
                DateTime start = dateTimePickerReportStart.Value;
                DateTime end = dateTimePickerReportEnd.Value;
                DateTime tmp = start;
                DateTime tmps = start;
                int counte = 0;
                attendaceReport.EmployeeID = new string[dataGridView12.Rows.Count];
                attendaceReport.TotalNoOfWork = new int[dataGridView12.Rows.Count];
                attendaceReport.TotalNoOfLate = new int[dataGridView12.Rows.Count];
                attendaceReport.TotalNoOfAbsent = new int[dataGridView12.Rows.Count];
                TotalHoursA = new int[dataGridView12.Rows.Count];
                TotalLateA  = new int[dataGridView12.Rows.Count];
                TotalHours12 = new int[dataGridView12.Rows.Count];
                TotalLate12 = new int[dataGridView12.Rows.Count];
                leave = new int[dataGridView12.Rows.Count];
                IDs = new string[dataGridViewAttendance123.Rows.Count];
                ID = new string[dataGridViewAttendanceReport.Rows.Count];
                total = new int[dataGridView12.Rows.Count];
                total2 = new int[dataGridView12.Rows.Count];
                totalabsent = new int[dataGridViewAttendanceReport.Rows.Count];
                totalLateAndAbsent = new int[dataGridViewAttendanceReport.Rows.Count];
                totalWork = new int[dataGridViewAttendanceReport.Rows.Count];
                attendaceReport.Period = attendanceReportsStart + "-" + attendanceReportsEnd;
                while (tmp <= end)
                {
                    if (tmp.DayOfWeek != DayOfWeek.Saturday && tmp.DayOfWeek != DayOfWeek.Sunday)
                    {
                        counte++;
                    }
                    tmp = tmp.AddDays(1);
                }
                DateTime[] startLeave;
                DateTime[] endLeave;
                DateTime[] startLeave2;
                DateTime[] endLeave2;
                string[] employeeIDLeave;
                string[] employeeIDLeave2;
                int[] countDay;
                startLeave = new DateTime[dataGridViewLeave.Rows.Count];
                endLeave = new DateTime[dataGridViewLeave.Rows.Count];
                employeeIDLeave = new string[dataGridViewLeave.Rows.Count];
                startLeave2 = new DateTime[dataGridViewLeave.Rows.Count];
                endLeave2 = new DateTime[dataGridViewLeave.Rows.Count];
                employeeIDLeave2 = new string[dataGridViewLeave.Rows.Count];
                countDay = new int[dataGridViewLeave.Rows.Count];
                int NoOfDay = 0;
                NoOfDay = counte * 8;
                for (int i = 0; i < dataGridViewLeave.Rows.Count; i++)
                {
                    startLeave[i] = Convert.ToDateTime(dataGridViewLeave.Rows[i].Cells["StartDate"].Value.ToString());
                    endLeave[i] = Convert.ToDateTime(dataGridViewLeave.Rows[i].Cells["EndDate"].Value.ToString());
                    employeeIDLeave[i] = dataGridViewLeave.Rows[i].Cells["EmployeeID"].Value.ToString();
                    if (startLeave[i] >= start)
                    {
                        startLeave2[i] = startLeave[i];
                    }
                    else
                    {
                        startLeave2[i] = start;
                    }
                    if (endLeave[i] <= end)
                    {
                        endLeave2[i] = endLeave[i];
                    }
                    else
                    {
                        endLeave2[i] = end;
                    }

                }
                for (int i = 0; i < dataGridViewLeave.Rows.Count; i++)
                {
                    while (startLeave2[i] <= endLeave2[i])
                    {
                        if (startLeave2[i].DayOfWeek != DayOfWeek.Saturday || startLeave2[i].DayOfWeek != DayOfWeek.Sunday)
                        {
                            countDay[i]++;
                            startLeave2[i] = startLeave2[i].AddDays(1);
                        }
                    }
                }
                int j = 0;
                for (int i = 0; i < dataGridView12.Rows.Count; i++)
                {
                    attendaceReport.EmployeeID[i] = dataGridView12.Rows[i].Cells["ID"].Value.ToString();
                    if (j < dataGridViewLeave.Rows.Count)
                    {
                        if (attendaceReport.EmployeeID[i] == employeeIDLeave[j])
                        {
                            leave[i] = countDay[j] * 8;
                            j++;
                        }
                    }
                }
                for (int i = 0; i < dataGridView12.Rows.Count; i++)
                {
                    attendaceReport.EmployeeID[i] = dataGridView12.Rows[i].Cells["ID"].Value.ToString();
                    for (int k = 0; k < dataGridViewAttendanceReport.Rows.Count; k++)
                    {
                        ID[k] = dataGridViewAttendanceReport.Rows[k].Cells["fldEmpID"].Value.ToString();
                        if (ID[k] == attendaceReport.EmployeeID[i])
                        {
                            TotalHours12[i] += Int32.Parse(dataGridViewAttendanceReport.Rows[k].Cells["TotalNoOfHours"].Value.ToString());
                            TotalLate12[i] += Int32.Parse(dataGridViewAttendanceReport.Rows[k].Cells["TotalNoOfLate"].Value.ToString());
                        }
                    }
                }
                for (int i = 0; i < dataGridView12.Rows.Count; i++)
                {
                    attendaceReport.EmployeeID[i] = dataGridView12.Rows[i].Cells["ID"].Value.ToString();
                    for (int y= 0; y < dataGridViewAttendance123.Rows.Count; y++)
                    {
                        IDs[y] = dataGridViewAttendance123.Rows[y].Cells["fldEmpID"].Value.ToString();
                        if (IDs[y] == attendaceReport.EmployeeID[i])
                        {
                            TotalHoursA[i] += Int32.Parse(dataGridViewAttendance123.Rows[y].Cells["TotalNoOfHours"].Value.ToString());
                            TotalLateA[i] += Int32.Parse(dataGridViewAttendance123.Rows[y].Cells["TotalNoOfLate"].Value.ToString());
                        }
                    }
                
                }
                for (int i = 0; i < dataGridView12.Rows.Count; i++)
                {
                    attendaceReport.TotalNoOfWork[i] = TotalHours12[i] + TotalHoursA[i];
                    attendaceReport.TotalNoOfLate[i] = TotalLate12[i] + TotalLateA[i];
                }
                for (int i = 0; i < dataGridView12.Rows.Count; i++)
                {
                        total[i] = attendaceReport.TotalNoOfWork[i] + leave[i];
                        total2[i] = total[i] + attendaceReport.TotalNoOfLate[i];
                        attendaceReport.TotalNoOfAbsent[i] = NoOfDay - total2[i];
                }

                for (int i = 0; i < dataGridView12.Rows.Count; i++)
                {
                    GenerateIDs();
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("qprocedureInsertAttendanceReport", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@AttenanceReportNo", attendaceReport.AttendanceReportNO));
                    cmd.Parameters.Add(new SqlParameter("@Period", attendaceReport.Period));
                    cmd.Parameters.Add(new SqlParameter("@TotalNoOfWork", total[i]));
                    cmd.Parameters.Add(new SqlParameter("@TotalNoLate", attendaceReport.TotalNoOfAbsent[i]));
                    cmd.Parameters.Add(new SqlParameter("@TotalNoOfaAbsent", attendaceReport.TotalNoOfLate[i]));
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", attendaceReport.EmployeeID[i]));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            #endregion
            #region payroll data
            string payrollss;
            string startss;
            string endss;
            string[] employeeIDLoan;
            string[] employeeIDLoanSSS;
            string[] employeeIDLoanPagIbig;
            string[] employeeIDBonus;
            decimal[] one;
            decimal[] two;
            decimal[] three;
            startss = dateTimePickerReportStart.Value.ToShortDateString();
            endss = dateTimePickerReportEnd.Value.ToShortDateString();
            payrollss = dateTimePickerReportStart.Value.ToShortDateString() + "-" + dateTimePickerReportEnd.Value.ToShortDateString();
            if (admin.CheckPayrollPeriod(payrollss))
            {
                MessageBox.Show("You HaveAlready Generated that Period");
                dateTimePickerReportStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dateTimePickerReportEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dateTimePickerPaydate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                return;
            }
            else
            {
                admin.Payroll(payrollss);
                admin.PayrollLoanCompany(startss, endss);
                admin.PayrollLoanSSS(startss, endss);
                admin.PayrollLoanPagIbig(startss, endss);
                admin.PayrollBonusFee(startss, endss);
                dataGridView1.DataSource = admin.DataSet.Tables["EmployeePayrolls"];
                dataGridViewLoanDeduction.DataSource = admin.DataSet.Tables["EmployeeLoanDeduction"];
                dataGridViewBonus.DataSource = admin.DataSet.Tables["EmployeeBonusFee"];
                dataGridViewLoanSSS.DataSource = admin.DataSet.Tables["EmployeeLoanDeductionSSS"];
                dataGridViewLoanPagIbig.DataSource = admin.DataSet.Tables["EmployeeLoanDeductionPagIbig"];
                this.dataGridView1.AllowUserToAddRows = false;
                this.dataGridViewBonus.AllowUserToAddRows = false;
                this.dataGridViewLoanDeduction.AllowUserToAddRows = false;
                this.dataGridViewLoanPagIbig.AllowUserToAddRows = false;
                this.dataGridViewLoanSSS.AllowUserToAddRows = false;
                payroll.TotalNoWork = new decimal[dataGridView1.Rows.Count];
                payroll.TotalNoLate = new decimal[dataGridView1.Rows.Count];
                payroll.TotalNoOvertime = new decimal[dataGridView1.Rows.Count];
                payroll.AttendanceReportNo = new string[dataGridView1.Rows.Count];
                payroll.SSSDeduction = new decimal[dataGridView1.Rows.Count];
                payroll.PhilHealthDeduction = new decimal[dataGridView1.Rows.Count];
                payroll.PagIbigDeduction = new decimal[dataGridView1.Rows.Count];
                payroll.SalaryPerMonth = new decimal[dataGridView1.Rows.Count];
                payroll.EmployeeID = new string[dataGridView1.Rows.Count];
                payroll.SalaryPerDay = new decimal[dataGridView1.Rows.Count];
                payroll.OverTimePay = new decimal[dataGridView1.Rows.Count];
                payroll.LateDeduction = new decimal[dataGridView1.Rows.Count];
                payroll.PagIbigDeductiona = new decimal[dataGridView1.Rows.Count];
                payroll.GrossPaya = new decimal[dataGridView1.Rows.Count];
                payroll.GrossPays = new decimal[dataGridView1.Rows.Count];
                payroll.GrossPayd = new decimal[dataGridView1.Rows.Count];
                payroll.GrossPayq = new decimal[dataGridView1.Rows.Count];
                payroll.GrossPay = new decimal[dataGridView1.Rows.Count];
                payroll.TaxDeductiona = new decimal[dataGridView1.Rows.Count];
                payroll.TaxDeductions = new decimal[dataGridView1.Rows.Count];
                payroll.TaxDeduction = new decimal[dataGridView1.Rows.Count];
                payroll.NetPay = new decimal[dataGridView1.Rows.Count];
                payroll.TaxExemption = new decimal[dataGridView1.Rows.Count];
                payroll.TaxOver = new decimal[dataGridView1.Rows.Count];
                payroll.Taxbase = new decimal[dataGridView1.Rows.Count];
                payroll.Bonus = new decimal[dataGridView1.Rows.Count];
                payroll.Loan = new decimal[dataGridView1.Rows.Count];
                payroll.LoanSSS = new decimal[dataGridView1.Rows.Count];
                payroll.LoanPagIbig = new decimal[dataGridView1.Rows.Count];
                payroll.GrossPaye = new decimal[dataGridView1.Rows.Count];
                one = new decimal[dataGridView1.Rows.Count];
                two = new decimal[dataGridView1.Rows.Count];
                three = new decimal[dataGridView1.Rows.Count];
                payroll.Date = dateTimePickerPaydate.Text;

                employeeIDBonus = new string[dataGridViewBonus.Rows.Count];
                employeeIDLoan = new string[dataGridViewLoanDeduction.Rows.Count];
                employeeIDLoanSSS = new string[dataGridViewLoanSSS.Rows.Count];
                employeeIDLoanPagIbig = new string[dataGridViewLoanPagIbig.Rows.Count];

                string[] dependent;
                dependent = new string[dataGridView1.Rows.Count];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    payroll.TotalNoWork[i] = decimal.Parse(dataGridView1.Rows[i].Cells["TotalNoOfWork"].Value.ToString());
                    payroll.TotalNoLate[i] = decimal.Parse(dataGridView1.Rows[i].Cells["TotalNoOfAbsent"].Value.ToString());
                    payroll.TotalNoOvertime[i] = decimal.Parse(dataGridView1.Rows[i].Cells["TotalNoOfLate"].Value.ToString());
                    payroll.AttendanceReportNo[i] = dataGridView1.Rows[i].Cells["AttendanceReportNo"].Value.ToString();
                    payroll.SSSDeduction[i] = decimal.Parse(dataGridView1.Rows[i].Cells["SocialSecurityEmployeeShare"].Value.ToString()) / 2;
                    payroll.PhilHealthDeduction[i] = decimal.Parse(dataGridView1.Rows[i].Cells["PhilHealthEmployeeShare"].Value.ToString()) / 2;
                    payroll.PagIbigDeduction[i] = decimal.Parse(dataGridView1.Rows[i].Cells["PagIbigEmployeeShare"].Value.ToString()) / 100;
                    payroll.SalaryPerMonth[i] = decimal.Parse(dataGridView1.Rows[i].Cells["Salary"].Value.ToString()) / 2;
                    payroll.EmployeeID[i] = dataGridView1.Rows[i].Cells["ID"].Value.ToString();
                    //MessageBox.Show(payroll.EmployeeID[i]);
                    dependent[i] = dataGridView1.Rows[i].Cells["NoOfDependent"].Value.ToString();
                    for (int x = 0; x < dataGridViewLoanDeduction.Rows.Count; x++)
                    {
                        employeeIDLoan[x] = dataGridViewLoanDeduction.Rows[x].Cells["EmployeeID"].Value.ToString();
                        if (employeeIDLoan[x] == payroll.EmployeeID[i])
                        {
                            payroll.Loan[i] = decimal.Parse(dataGridViewLoanDeduction.Rows[x].Cells["TotalAmorzitation"].Value.ToString()) / 2;
                        }
                    }
                    for (int y = 0; y < dataGridViewLoanSSS.Rows.Count; y++)
                    {
                        employeeIDLoanSSS[y] = dataGridViewLoanSSS.Rows[y].Cells["EmployeeID"].Value.ToString();
                        if (employeeIDLoanSSS[y] == payroll.EmployeeID[i])
                        {
                            payroll.LoanSSS[i] = decimal.Parse(dataGridViewLoanSSS.Rows[y].Cells["TotalAmorzitation"].Value.ToString()) / 2;
                        }
                    } for (int z = 0; z < dataGridViewLoanPagIbig.Rows.Count; z++)
                    {
                        employeeIDLoanPagIbig[z] = dataGridViewLoanPagIbig.Rows[z].Cells["EmployeeID"].Value.ToString();
                        if (employeeIDLoanPagIbig[z] == payroll.EmployeeID[i])
                        {
                            payroll.LoanPagIbig[i] = decimal.Parse(dataGridViewLoanPagIbig.Rows[z].Cells["TotalAmorzitation"].Value.ToString()) / 2;
                        }
                    }
                    for (int o = 0; o < dataGridViewBonus.Rows.Count; o++)
                    {
                        employeeIDBonus[o] = dataGridViewBonus.Rows[o].Cells["EmployeeID"].Value.ToString();
                        if (employeeIDBonus[o] == payroll.EmployeeID[i])
                        {
                            payroll.Bonus[i] += decimal.Parse(dataGridViewBonus.Rows[o].Cells["Amount"].Value.ToString());

                        }
                        //MessageBox.Show(payroll.Bonus[i].ToString());
                    }
                }
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    payroll.SalaryPerDay[i] = payroll.SalaryPerMonth[i] / 80;
                    payroll.OverTimePay[i] = payroll.SalaryPerDay[i] * payroll.TotalNoOvertime[i];
                    payroll.LateDeduction[i] = payroll.SalaryPerDay[i] * payroll.TotalNoLate[i];
                    payroll.PagIbigDeductiona[i] = payroll.SalaryPerMonth[i] * payroll.PagIbigDeduction[i];
                    one[i] = payroll.SalaryPerDay[i] * payroll.TotalNoWork[i];
                    payroll.GrossPaya[i] = one[i] + payroll.Bonus[i];
                    payroll.GrossPaye[i] = payroll.LoanPagIbig[i] + payroll.LoanSSS[i];
                    two[i] = payroll.SSSDeduction[i] + payroll.PhilHealthDeduction[i];
                    three[i] = payroll.GrossPaye[i] + payroll.Loan[i];
                    payroll.GrossPays[i] = two[i] + three[i];
                    payroll.GrossPayd[i] = payroll.OverTimePay[i] + payroll.LateDeduction[i];
                    payroll.GrossPayq[i] = payroll.GrossPays[i] + payroll.PagIbigDeductiona[i];
                    payroll.GrossPay[i] = payroll.GrossPaya[i] - payroll.GrossPayq[i];
                    foreach (DataRow dataRow in admin.DataSet.Tables["Tax"].Rows)
                    {
                        decimal o = decimal.Parse(dataRow["TaxFrom"].ToString());
                        decimal h = decimal.Parse(dataRow["TaxTo"].ToString());
                        if (o <= payroll.GrossPay[i] && h > payroll.GrossPay[i] && dependent[i] == dataRow["NoOfDependent"].ToString())
                        {
                            payroll.TaxExemption[i] = decimal.Parse(dataRow["TaxExemption"].ToString());
                            payroll.TaxOver[i] = decimal.Parse(dataRow["PercentOver"].ToString()) / 100;
                            payroll.Taxbase[i] = decimal.Parse(dataRow["TaxFrom"].ToString());
                        }

                    }

                    payroll.TaxDeductiona[i] = payroll.GrossPay[i] - payroll.Taxbase[i];
                    payroll.TaxDeductions[i] = payroll.TaxDeductiona[i] * payroll.TaxOver[i];
                    payroll.TaxDeduction[i] = payroll.TaxDeductions[i] + payroll.TaxExemption[i];
                    payroll.NetPay[i] = payroll.GrossPay[i] - payroll.TaxDeduction[i];
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    GenerateID();
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("fprocedureInsertPayroll", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PayrollID", payroll.PayrollID));
                    cmd.Parameters.Add(new SqlParameter("@Date", payroll.Date));
                    cmd.Parameters.Add(new SqlParameter("@Period", payrollss));
                    cmd.Parameters.Add(new SqlParameter("@SalaryPerMonth", payroll.SalaryPerMonth[i]));
                    cmd.Parameters.Add(new SqlParameter("@Salary", payroll.GrossPaya[i]));
                    cmd.Parameters.Add(new SqlParameter("@Late", payroll.GrossPayd[i]));
                    cmd.Parameters.Add(new SqlParameter("@BonusFee", payroll.Bonus[i]));
                    cmd.Parameters.Add(new SqlParameter("@Loan", payroll.Loan[i]));
                    cmd.Parameters.Add(new SqlParameter("@LoanSSS", payroll.LoanSSS[i]));
                    cmd.Parameters.Add(new SqlParameter("@LoanPagIbig", payroll.LoanPagIbig[i]));
                    cmd.Parameters.Add(new SqlParameter("@SSSDeduction", payroll.SSSDeduction[i]));
                    cmd.Parameters.Add(new SqlParameter("@PhilHealthDeduction", payroll.PhilHealthDeduction[i]));
                    cmd.Parameters.Add(new SqlParameter("@PagIbigDeduction", payroll.PagIbigDeductiona[i]));
                    cmd.Parameters.Add(new SqlParameter("@TaxDeduction", payroll.TaxDeduction[i]));
                    cmd.Parameters.Add(new SqlParameter("@GrossPay", payroll.GrossPay[i]));
                    cmd.Parameters.Add(new SqlParameter("@NetPay", payroll.NetPay[i]));
                    cmd.Parameters.Add(new SqlParameter("@AttendanReportNo", payroll.AttendanceReportNo[i]));
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", payroll.EmployeeID[i]));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Record Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            #endregion
            dataGridView1.DataSource = null;
            dataGridViewBonus.DataSource = null;
            dataGridViewLoanDeduction.DataSource = null;
            dataGridViewLoanPagIbig.DataSource = null;
            dataGridViewLoanSSS.DataSource = null;
            dataGridViewLeave.DataSource = null;
            dataGridView12.DataSource = null;
            dataGridViewAttendanceReport.DataSource = null;
            dataGridViewAttendance123.DataSource = null;
            
                
            //admin.RecordPayroll(payrollss);
            //dataGridView2.DataSource = admin.DataSet.Tables["JoinEmployeePayrollsss"];
            //dataGridView2.AllowUserToAddRows = false;
            
        }
        private void Payroll_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = (@"Data Source=JUNEBUG;Initial Catalog=FP_SAMPLE;Integrated Security=True ");
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("SELECT * FROM Payroll;", conDataBase);

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
