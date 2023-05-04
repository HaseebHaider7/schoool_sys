using FluentValidation.Results;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Validators;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class addNewclassForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Classroom classroom = new Classroom();

        public addNewclassForm()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(feeTextBox.Text, @" ^ -? (0 |[1 - 9]\d{ 0,1})([,\.]\d{ 1,2})?$"))
            {
                MessageBox.Show("Please enter only numbers.");
                feeTextBox.Text = feeTextBox.Text.Remove(feeTextBox.Text.Length - 1);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            classroom.ClassName = classdropdown.Text;
            try
            {
                classroom.ClassFee = decimal.Parse(feeTextBox.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show("Fee must be in decimal number format: ");

            }

            ClassValidator cv = new ClassValidator();
            var results = cv.Validate(classroom);


            if (results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage.ToString(), failure.PropertyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DataSetTableAdapters.classesTableAdapter ClassAdapter = new DataSetTableAdapters.classesTableAdapter();
                DataTable checkingDt = ClassAdapter.CheckClassExistence(classroom.ClassName);
                if (checkingDt.Rows.Count > 0)
                {
                    MessageBox.Show("Class Already Exist:","Class Duplicating",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    ClassAdapter.AddClass(classroom.ClassName, classroom.ClassFee);
                    this.Close();
                }


            }
        }

        private void closehoverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
