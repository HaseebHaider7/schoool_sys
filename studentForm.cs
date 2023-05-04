using FluentValidation.Results;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Validators;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StudentForm : Form
    {
        Student Std = new Student();
        Classroom cls = new Classroom();
        MySqlConfig MysqlConfig = new MySqlConfig();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            this.studentTableAdapter.Fill(this.dataSet1.student);
            for (int i = 0; i < studentDataGridView.Columns.Count; i++)
            {
                if (studentDataGridView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)studentDataGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

            }
            studentDataGridView.ClearSelection();

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (viewByPanel.Visible == false)
            {
                viewByPanel.Visible = true;
                viewBySectionPanel.Visible = false;
                viewByClassPanel.Visible = false;

            }
            else
            {
                viewByPanel.Visible = false;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (ViewBySectionRadioButton.Checked == true)
            {

                this.classesTableAdapter.FillByGroupByclass(this.dataSet.classes);
                this.sectionTableAdapter.FillByGroupedSection(this.dataSet.section);
                viewByPanel.Visible = false;
                viewBySectionPanel.Visible = true;


            }
            else if (ViewByClassRadioButton.Checked == true)
            {

                this.classesTableAdapter.FillByGroupByclass(this.dataSet.classes);
                viewByPanel.Visible = false;
                viewByClassPanel.Visible = true;

            }
        }

        private void sectionDoneBtn_Click(object sender, EventArgs e)
        {
            cls.ClassName = classDropdown.Text;
            cls.Section = sectionDropdown.Text;

            DataSetTableAdapters.studentTableAdapter studentAdapter = new DataSetTableAdapters.studentTableAdapter();
            DataTable dt = studentAdapter.GetDataByClassAndSection(cls.ClassName, cls.Section);
            studentDataGridView.DataSource = dt;
            studentDataGridView.ClearSelection();
            viewBySectionPanel.Visible = false;



        }

        private void classDoneBtn_Click(object sender, EventArgs e)
        {
            cls.ClassName = classesDropdown.Text;
            DataSetTableAdapters.studentTableAdapter studentAdapter = new DataSetTableAdapters.studentTableAdapter();
            DataTable dt = studentAdapter.GetDataByClass(cls.ClassName);
            studentDataGridView.DataSource = dt;
            studentDataGridView.ClearSelection();
            viewByClassPanel.Visible = false;
        }

        private void addnewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewStudentForm add = new AddNewStudentForm();
                add.ShowDialog();
                studentDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.studentTableAdapter.Fill(this.dataSet1.student);
                studentDataGridView.ClearSelection();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (studentDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    Std.StudentImage = (byte[])studentDataGridView.SelectedRows[0].Cells[0].Value;
                    Std.AdmissionID = studentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    Std.AdmissionDate = Convert.ToDateTime(studentDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                    Std.StdRollNo = int.Parse(studentDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                    Std.StudentName = studentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    Std.FatherName = studentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    Std.FatherMobileNo = studentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    Std.StudentDateOfBirth = Convert.ToDateTime(studentDataGridView.SelectedRows[0].Cells[7].Value.ToString());
                    Std.age = int.Parse(studentDataGridView.SelectedRows[0].Cells[8].Value.ToString());
                    Std.DateOfBirthInWord = studentDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                    Std.gender = studentDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                    Std.DateOfBirthInWord = studentDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                    Std.StudentResidence = studentDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                    Std.Qaum = studentDataGridView.SelectedRows[0].Cells[12].Value.ToString();
                    Std.Religion = studentDataGridView.SelectedRows[0].Cells[13].Value.ToString();
                    Std.sectionID = int.Parse(studentDataGridView.SelectedRows[0].Cells[14].Value.ToString());
                    Std.AdmissionClass = studentDataGridView.SelectedRows[0].Cells[15].Value.ToString();
                    Std.AdmissionSection = studentDataGridView.SelectedRows[0].Cells[16].Value.ToString();




                    StudentValidator validator = new StudentValidator();
                    var results = validator.Validate(Std);

                    if (results.IsValid == false)
                    {
                        foreach (ValidationFailure failure in results.Errors)
                        {
                            MessageBox.Show(failure.ErrorMessage.ToString(), failure.PropertyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        this.studentTableAdapter.Fill(this.dataSet1.student);
                        studentDataGridView.ClearSelection();
                    }
                    else
                    {

                        this.studentTableAdapter.Update(dataSet1.student);
                        this.studentTableAdapter.Fill(this.dataSet1.student);
                        studentDataGridView.ClearSelection();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Select Student to Update: ");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (studentDataGridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Std.StudentImage = (byte[])studentDataGridView.SelectedRows[0].Cells[0].Value;
                        Std.AdmissionID = studentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        Std.AdmissionDate = Convert.ToDateTime(studentDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                        Std.StdRollNo = int.Parse(studentDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                        Std.StudentName = studentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                        Std.FatherName = studentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                        Std.FatherMobileNo = studentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                        Std.StudentDateOfBirth = Convert.ToDateTime(studentDataGridView.SelectedRows[0].Cells[7].Value.ToString());
                        Std.DateOfBirthInWord = studentDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                        Std.StudentResidence = studentDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                        Std.Qaum = studentDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                        Std.Religion = studentDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                        Std.sectionID = int.Parse(studentDataGridView.SelectedRows[0].Cells[12].Value.ToString());
                        Std.AdmissionClass = studentDataGridView.SelectedRows[0].Cells[13].Value.ToString();
                        Std.AdmissionSection = studentDataGridView.SelectedRows[0].Cells[14].Value.ToString();
                        Std.gender = studentDataGridView.SelectedRows[0].Cells[15].Value.ToString();
                        Std.age = int.Parse(studentDataGridView.SelectedRows[0].Cells[16].Value.ToString());

                        this.studentTableAdapter.RemoveStudent(Std.AdmissionID, Std.AdmissionDate, Std.StdRollNo, Std.StudentName, Std.FatherName,
                                                                Std.FatherMobileNo, Std.StudentDateOfBirth, Std.DateOfBirthInWord, Std.StudentResidence,
                                                                Std.Qaum, Std.Religion, Std.AdmissionClass, Std.AdmissionSection, Std.gender, Std.age, Std.sectionID);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.studentTableAdapter.Fill(this.dataSet1.student);
                        studentDataGridView.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Student to Delete");
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM sms_database.student WHERE CONCAT (`studentName`,`residence`,`qaum`,`religion`,`classes`,`section`,`gender`,`age`) like '%" + searchTextbox.Text + "%'";

            MysqlConfig.SearchResults(searchQuery, studentDataGridView);
        }
    }
}
