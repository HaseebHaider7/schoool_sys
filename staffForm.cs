using FluentValidation.Results;
using SchoolManagementSystem.Validators;
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class staffForm : Form
    {
        Data.Staff staff = new Data.Staff();
        MySqlConfig MySqlConfig = new MySqlConfig();
        public staffForm()
        {
            InitializeComponent();
        }

        private void staffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dataSet.staff);
            staffDataGridView.ClearSelection();

        }

        private void addnewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddStaffForm add = new AddStaffForm();
                add.ShowDialog();
                staffDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.staffTableAdapter.Fill(this.dataSet.staff);
                staffDataGridView.ClearSelection();
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    staff.FullName = staffDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    staff.Cnic = staffDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    staff.MobileNo = staffDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    staff.StaffDesignation = staffDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    staff.JoiningDate = DateTime.Parse(staffDataGridView.SelectedRows[0].Cells[5].Value.ToString());

                    StaffValidator validator = new StaffValidator();
                    var results = validator.Validate(staff);

                    if (results.IsValid == false)
                    {
                        foreach (ValidationFailure failure in results.Errors)
                        {
                            MessageBox.Show(failure.ErrorMessage.ToString(), failure.PropertyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {

                        this.staffTableAdapter.Update(dataSet.staff);
                        staffDataGridView.Refresh();
                        staffDataGridView.ClearSelection();
                        MessageBox.Show("Record Updated");
                    }
                    this.staffTableAdapter.Fill(this.dataSet.staff);
                    staffDataGridView.ClearSelection();
                }
                else
                {
                    this.staffTableAdapter.Fill(this.dataSet.staff);
                    staffDataGridView.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please select row to Update: ");
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.staffDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete selected Staff", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    try
                    {

                        int stg1 = int.Parse(staffDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        string stg2 = staffDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        string stg3 = staffDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                        string stg4 = staffDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                        string stg5 = staffDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                        DateTime stg6 = Convert.ToDateTime(staffDataGridView.SelectedRows[0].Cells[5].Value.ToString());
                        this.staffTableAdapter.DeleteStaff(stg1, stg2, stg3, stg4, stg5, stg6);
                        staffDataGridView.Refresh();
                        MessageBox.Show("Record Deleted");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.staffTableAdapter.Fill(this.dataSet.staff);
                        staffDataGridView.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select row to delete: ");
            }

        }



        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM sms_database.staff WHERE CONCAT (`staff_id`,`staff_name`,`staff_cnic`,`staff_mob`,`staff_designation`,`staff_joining_date`) like '%" + searchTextbox.Text + "%'";

            MySqlConfig.SearchResults(searchQuery, staffDataGridView);

        }

        private void staffDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Joining Date Must be A valid Date:","Invalid Date Format",MessageBoxButtons.OK,MessageBoxIcon.Error);
            this.staffTableAdapter.Fill(this.dataSet.staff);
            staffDataGridView.ClearSelection();
        }
    }
}
