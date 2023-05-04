using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class staffDesignationForm : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=sms_database;persistsecurityinfo=True;allowloadlocalinfile=False;sslmode=None;username=root;password=root@admin");

        public staffDesignationForm()
        {
            InitializeComponent();
        }

        private void addnewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewStaffDesForm add = new AddNewStaffDesForm();
                add.ShowDialog();
                staffDesDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.staff_designationTableAdapter.Fill(this.dataSet.staff_designation);
                staffDesDataGridView.ClearSelection();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (staffDesDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    this.staff_designationTableAdapter.Update(dataSet.staff_designation);
                    staffDesDataGridView.Refresh();
                    staffDesDataGridView.ClearSelection();
                    MessageBox.Show("Record Updated");
                }

            }
            else
            {
                MessageBox.Show("Please Select Row to update :");
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.staffDesDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete selected data", "Message", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {


                    try
                    {

                        int stg1 = int.Parse(staffDesDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        string stg2 = staffDesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        this.staff_designationTableAdapter.Delete(stg1, stg2);
                        staffDesDataGridView.Refresh();
                        MessageBox.Show("Record Deleted");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.staff_designationTableAdapter.Fill(this.dataSet.staff_designation);
                        staffDesDataGridView.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Row to delete :");
            }

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.staff_designationTableAdapter.Fill(this.dataSet.staff_designation);
            staffDesDataGridView.Refresh();
            staffDesDataGridView.Sort(staffDesDataGridView.Columns[0], ListSortDirection.Ascending);
            staffDesDataGridView.ClearSelection();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string searchQuery = "SELECT * FROM sms_database.staff_designation WHERE CONCAT (`idstaff_designation`,`staff_designation`) like '%" + searchTextbox.Text + "%'";
                MySqlCommand command = new MySqlCommand(searchQuery, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                staffDesDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            staffDesDataGridView.ClearSelection();
        }

        private void staffDesignationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.staff_designation' table. You can move, or remove it, as needed.
            this.staff_designationTableAdapter.Fill(this.dataSet.staff_designation);
            staffDesDataGridView.ClearSelection();
        }
    }
}
