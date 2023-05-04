using FluentValidation.Results;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Validators;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ClassroomForm : Form
    {
        Classroom classroom = new Classroom();
        public ClassroomForm()
        {
            InitializeComponent();
        }

        private void ClassroomForm_Load(object sender, EventArgs e)
        {
            this.classesTableAdapter1.Fill(this.dataSet.classes);
            classDataGridView.ClearSelection();
            classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void addnewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addNewclassForm add = new addNewclassForm();
                add.ShowDialog();
                classDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.classesTableAdapter1.Fill(this.dataSet.classes);
                classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
                classDataGridView.ClearSelection();
            }
        }

        private void updatetBtn_Click(object sender, EventArgs e)
        {
            if (classDataGridView.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    classroom.ClassName = classDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                    try
                    {

                        classroom.ClassFee = decimal.Parse(classDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    }
                    catch (Exception)
                    {

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
                        this.classesTableAdapter1.Update(dataSet.classes);

                        classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
                        MessageBox.Show("Record Updated");
                    }
                    this.classesTableAdapter1.Fill(this.dataSet.classes);
                    classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
                    classDataGridView.ClearSelection();
                }
                else
                {
                    this.classesTableAdapter1.Fill(this.dataSet.classes);
                    classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
                    classDataGridView.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Please select row to edit:");

            }

        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.classDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete selected data", "Message", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        string classname = classDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        decimal classfee = decimal.Parse(classDataGridView.SelectedRows[0].Cells[1].Value.ToString());

                        this.classesTableAdapter1.DeleteClass(classname, classfee);
                        classDataGridView.Refresh();
                        classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);

                        MessageBox.Show("Record Deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.classesTableAdapter1.Fill(this.dataSet.classes);
                        classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
                        classDataGridView.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select row to delete :");
            }

        }

        private void classDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Class Fee must be in decimal:", "Input Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.classesTableAdapter1.Fill(this.dataSet.classes);
            classDataGridView.Sort(classDataGridView.Columns[0], ListSortDirection.Ascending);
            classDataGridView.ClearSelection();
        }

        private void classDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
    }
}
