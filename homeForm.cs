using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class homeForm : Form
    {
        MySqlConfig mysqlConfig = new MySqlConfig();
        int totalstudent = 110, totalteacher, totalnonteacher;
        public homeForm()
        {
            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            string selectstudent = "SELECT admission_id FROM sms_database.student";
            totalstudent = mysqlConfig.maxrow(selectstudent);

            string validate = "Non Teaching Staff";
            string selectstaff = "SELECT staff_id FROM sms_database.staff Where staff_designation != '" + validate + "'";
            totalteacher = mysqlConfig.maxrow(selectstaff);

            string selectNonTstaff = "SELECT staff_id FROM sms_database.staff Where staff_designation = '" + validate + "'";
            totalnonteacher = mysqlConfig.maxrow(selectNonTstaff);


            studentValueLabel.Text = $"{ totalstudent }";
            teacherValueLabel.Text = $"{ totalteacher }";
            nonTValueLabel.Text = $"{ totalnonteacher }";
        }
    }
}
