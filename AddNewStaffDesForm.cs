using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddNewStaffDesForm : Form
    {
        MySqlConfig MSC = new MySqlConfig();
        string sql;
        String staffDesignation;
        public AddNewStaffDesForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            staffDesignation = staffDesignationTextbox.Text;

            if (staffDesignationTextbox.Text == string.Empty)
            {
                MessageBox.Show("Please type in Designation");
            }
            else
            {

                sql = "INSERT INTO sms_database.staff_designation (staff_designation)" +
                "VALUES ('" + staffDesignation + "')";

                MSC.Execute_CUD(sql, "error to execute query", "Data stored");
                this.Close();



            }

        }

        private void closehoverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void staffDesignationTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
