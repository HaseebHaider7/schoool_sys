
using FluentValidation.Results;
using SchoolManagementSystem.Validators;
using System;
using System.Windows.Forms;


namespace SchoolManagementSystem
{
    public partial class AddStaffForm : Form
    {
        Data.Staff Staff = new Data.Staff();

        public AddStaffForm()
        {
            InitializeComponent();
            this.DatePicker.Value = DateTime.Now;
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.staff_designation' table. You can move, or remove it, as needed.
            this.staff_designationTableAdapter.Fill(this.dataSet.staff_designation);
        }

        private void closehoverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Staff.FullName = staffnameTextbox.Text;
            Staff.Cnic = CnicTextBox.Text;
            Staff.MobileNo = mobileTextBox.Text;
            Staff.StaffDesignation = desdropdown.Text;
            Staff.JoiningDate = DatePicker.Value.Date;
            StaffValidator validator = new StaffValidator();
            var results = validator.Validate(Staff);

            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage.ToString(), failure.PropertyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DataSetTableAdapters.staffTableAdapter StaffAdapter = new DataSetTableAdapters.staffTableAdapter();
                StaffAdapter.Insert(Staff.FullName, Staff.Cnic, Staff.MobileNo, Staff.StaffDesignation, Staff.JoiningDate);
                this.Close();
            }
        }
    }
}
