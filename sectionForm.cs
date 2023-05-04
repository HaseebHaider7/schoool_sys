using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SchoolManagementSystem
{

    public partial class sectionForm : Form
    {


        MySqlConfig mysqlConfig = new MySqlConfig();

        public sectionForm()
        {
            InitializeComponent();
        }


        private void addnewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addNewSecForm add = new addNewSecForm();
                add.ShowDialog();
                sectionDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sectionTableAdapter.Fill(this.dataSet.section);
                sectionDataGridView.ClearSelection();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (this.sectionDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    this.sectionTableAdapter.Update(dataSet.section);
                    sectionDataGridView.Refresh();
                    MessageBox.Show("Record Updated");
                }
                sectionDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select row to Update:");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (this.sectionDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete selected data", "Message", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {


                    try
                    {
                        int stg1 = int.Parse(sectionDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        string stg2 = sectionDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        string stg3 = sectionDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                        this.sectionTableAdapter.Delete(stg1, stg2, stg3);
                        sectionDataGridView.Refresh();
                        MessageBox.Show("Record Deleted");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.sectionTableAdapter.Fill(this.dataSet.section);
                        sectionDataGridView.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("PLease Select row to delete: ");
            }
        }



        private void sectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.dataSet.section);
            sectionDataGridView.Sort(sectionDataGridView.Columns[0], ListSortDirection.Ascending);

            sectionDataGridView.ClearSelection();
        }

        private void searchTextbox_TextChange(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM sms_database.section WHERE CONCAT (`classes`,`section`) like '%" + searchTextbox.Text + "%'";

            mysqlConfig.SearchResults(searchQuery, sectionDataGridView);


        }


    }
}
