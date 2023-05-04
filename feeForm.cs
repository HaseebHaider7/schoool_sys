using FluentValidation.Results;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.DataSetTableAdapters;
using SchoolManagementSystem.Validators;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class FeeForm : Form
    {
        string classes, section;
        FeeStructure Fee = new FeeStructure();
        fee_structureTableAdapter feeAda = new fee_structureTableAdapter();



        public FeeForm()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

            if (classdropdown.Text != "Select Class" && secDropdown.Text != "Select Section" &&
                classdropdown.Text != null && secDropdown.Text != null)
            {
                classes = classdropdown.Text;
                section = secDropdown.Text;
                Fee.feeMonth = DateTime.Now.ToString("MMMM/yy");

                DataTable dt = feeAda.GetDataBy(classes, section, Fee.feeMonth);

                if (dt.Rows.Count > 0)
                {
                    //we have data
                    DataTable dt_new = feeAda.GetDataBy(classes, section, Fee.feeMonth);
                    feeDataGridView.DataSource = dt_new;
                }
                else
                {
                    // we need to apply check on remaining payment if available then have to add it to this month payment.
                    // we dont have data for current month we need to generate them

                    string previousMonth = DateTime.Now.AddMonths(-1).ToString("MMMM/yy");
                    studentTableAdapter stdAda = new studentTableAdapter();
                    DataTable stdDT = stdAda.GetDataByClassAndSection(classes, section);

                    classesTableAdapter actualfee = new classesTableAdapter();
                    Fee.ActualAmount = (decimal)actualfee.SelectFeeByClass(classes);

                    DataTable dt2 = feeAda.GetDataBy(classes, section, previousMonth);
                    if (dt2.Rows.Count > 0)
                    {

                        Fee.paid = 0M;
                        Fee.status = "Not Paid";
                        Fee.feeYear = DateTime.Now.Year;
                        Fee.dueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/25"));

                        if (stdDT.Rows.Count > 0)
                        {
                            foreach (DataRow rows in stdDT.Rows)
                            {
                                //Insert new Data
                                decimal previousRemaining = (decimal)feeAda.SelectRemainingAmount(rows[1].ToString(), classes, section, previousMonth);
                                Fee.remaining = Fee.ActualAmount + previousRemaining;
                                feeAda.InsertQuery(rows[1].ToString(), rows[4].ToString(), Fee.paid, Fee.remaining, Fee.ActualAmount, Fee.status,
                                                    Fee.dueDate, Fee.paymentDate, Fee.feeMonth, Fee.feeYear, classes, section);
                            }
                            DataTable dt_new = feeAda.GetDataBy(classes, section, Fee.feeMonth);
                            feeDataGridView.DataSource = dt_new;
                        }

                    }
                    else
                    {

                        Fee.remaining = Fee.ActualAmount;
                        Fee.paid = 0M;
                        Fee.status = "Not Paid";
                        Fee.feeYear = DateTime.Now.Year;
                        Fee.dueDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/25"));

                        if (stdDT.Rows.Count > 0)
                        {
                            foreach (DataRow row in stdDT.Rows)
                            {
                                //Insert new Data
                                feeAda.InsertQuery(row[1].ToString(), row[4].ToString(), Fee.paid, Fee.remaining, Fee.ActualAmount, Fee.status,
                                                    Fee.dueDate, Fee.paymentDate, Fee.feeMonth, Fee.feeYear, classes, section);
                            }

                        }
                        else
                        {

                            MessageBox.Show("NO student record found", "Empty Section", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DataTable dt_new = feeAda.GetDataBy(classes, section, Fee.feeMonth);
                        feeDataGridView.DataSource = dt_new;
                    }

                }

            }
            else
            {
                MessageBox.Show("Please Select Class and Section:");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            decimal previousPaid = 0;
            if (feeDataGridView.SelectedRows.Count > 0)
            {
                if (feeDataGridView.SelectedRows[0].Cells[5].Value.ToString() == "Paid")
                {
                    MessageBox.Show("Student Already Paid Fee");
                }
                else
                {
                    try
                    {
                        Fee.paid = decimal.Parse(feeDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                        Fee.remaining = decimal.Parse(feeDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                    }
                    catch (Exception) { }

                    Fee.remaining = Fee.remaining - Fee.paid;
                    if (Fee.remaining < 0)
                    {
                        Fee.status = "Over Paid";
                        Fee.paymentDate = DateTime.Now.Date;
                    }
                    else if (Fee.remaining > 0)
                    {
                        Fee.status = "Not Paid";
                        Fee.paymentDate = null;
                    }
                    else
                    {
                        Fee.status = "Paid";
                        Fee.paymentDate = DateTime.Now.Date;
                        feeDataGridView.SelectedRows[0].Cells[2].ReadOnly = true;
                    }

                    try
                    {
                        Fee.paid = decimal.Parse(feeDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                        Fee.paid = Fee.paid + previousPaid;
                    }
                    catch (Exception) { }

                    FeeValidator validator = new FeeValidator();
                    var results = validator.Validate(Fee);
                    if (results.IsValid == false)
                    {
                        foreach (ValidationFailure failure in results.Errors)
                        {
                            MessageBox.Show(failure.ErrorMessage.ToString(), failure.PropertyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        previousPaid = (decimal)feeAda.SelectPreviousPaidAmount(feeDataGridView.SelectedRows[0].Cells[0].Value.ToString(), Fee.feeMonth);
                        Fee.paid = Fee.paid + previousPaid;
                        feeAda.UpdateQuery(Fee.paid, Fee.remaining, Fee.status, Fee.paymentDate, feeDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        DataTable dt_new = feeAda.GetDataBy(classes, section, Fee.feeMonth);
                        feeDataGridView.DataSource = dt_new;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select row to update: ");
            }
        }

        private void feeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Class Fee must be in decimal:", "Input Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }

        private void classdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            classes = classdropdown.Text;
            if (classes != null)
            {
                this.sectionTableAdapter.FillBySecWC(this.dataSet.section, classes);
            }

        }

        private void secDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            section = secDropdown.Text;
        }

        private void FeeForm_Load(object sender, EventArgs e)
        {
            this.classesTableAdapter.FillBySortedClass(this.dataSet.classes);

        }
    }



}
