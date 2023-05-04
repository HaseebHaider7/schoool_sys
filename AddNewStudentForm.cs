using FluentValidation.Results;
using MySql.Data.MySqlClient;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Validators;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddNewStudentForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        DataSetTableAdapters.studentTableAdapter studentAdapter = new DataSetTableAdapters.studentTableAdapter();
        FileStream fs;
        BinaryReader br;
        bool checker = false;
        MySqlConfig MSC = new MySqlConfig();
        Student STD = new Student();

        public AddNewStudentForm()
        {
            InitializeComponent();
            AdmissionDatePicker.Value = DateTime.Now;
            DOBDatePicker.Value = DateTime.Now;
            GeneratingAdmissionID();
            ReligionDropdown.SelectedItem = "Muslim";

        }

        private void GeneratingAdmissionID()
        {
            MSC.con.Open();
            MySqlCommand cmd = new MySqlCommand("Select Max(admission_id) from student", MSC.con);

            var dr = cmd.ExecuteReader();
            string newId = string.Format("APS-{0}-000001", DateTime.Now.Year);
            if (dr.HasRows)
            {
                string prefix = string.Format("APS-{0}", DateTime.Now.Year);
                while (dr.Read())
                {

                    string maxId = dr[0].ToString();
                    if (!string.IsNullOrWhiteSpace(maxId) && maxId.StartsWith(prefix))
                    {
                        int count = Convert.ToInt32(maxId.Split('-')[2]);
                        newId = string.Format("APS-{0}-{1:000000}", DateTime.Now.Year, count + 1);
                    }
                }
            }
            STD.AdmissionID = newId;
            AddmissionNoTextBox.Text = STD.AdmissionID;
            MSC.con.Close();
        }


        private void GettingRollNo(string cls, string section)
        {
            int rollno = 0;

            try
            {

                rollno = (int)studentAdapter.SelectMaxRollNo(cls, section);
                if (rollno > 0)
                {
                    rollno += 1;
                }

            }
            catch (Exception)
            {
                DialogResult dr = MessageBox.Show("This section do not have any student yet. Do you want to add new student.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    rollno = 1;
                }
                else if (dr == DialogResult.No)
                {

                    classdropdown.SelectedIndex = 0;
                    secDropdown.SelectedIndex = 0;
                    GetRollNoBtn.Visible = true;
                    classdropdown.Focus();
                }
            }

            STD.StdRollNo = rollno;
            RollNoTextBox.Text = STD.StdRollNo.ToString();

        }


        private void closehoverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (studentPicture.Text.Length > 0)
            {
                string FileName = studentPicture.Text;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                STD.StudentImage = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }
            else if (checker == false)
            {
                DialogResult dr = MessageBox.Show("Do You Want To Use Default Student Image:", "Student Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (GenderDropdown.Text == "Male")
                    {

                        studentPicture.Image = Image.FromFile("D:\\My coded Software\\SchoolManagementSystem\\SchoolManagementSystem\\Resources\\male_Student1.png");
                        string filename = "D:\\My coded Software\\SchoolManagementSystem\\SchoolManagementSystem\\Resources\\male_Student1.png";
                        fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        STD.StudentImage = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                    }
                    else if (GenderDropdown.Text == "Female")
                    {
                        studentPicture.Image = Image.FromFile("D:\\My coded Software\\SchoolManagementSystem\\SchoolManagementSystem\\Resources\\female_Student1.png");
                        string filename = "D:\\My coded Software\\SchoolManagementSystem\\SchoolManagementSystem\\Resources\\female_Student1.png";
                        fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        STD.StudentImage = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                    }
                }
            }

            STD.AdmissionID = AddmissionNoTextBox.Text;
            STD.AdmissionDate = AdmissionDatePicker.Value.Date;
            STD.AdmissionClass = classdropdown.Text;
            STD.AdmissionSection = secDropdown.Text;
            STD.StudentName = StudentNameTextBox.Text;
            STD.FatherName = fatherTextBox.Text;
            STD.FatherMobileNo = mobileTextBox.Text;
            STD.StudentDateOfBirth = DOBDatePicker.Value.Date;
            STD.DateOfBirthInWord = DOBwordTextBox.Text;
            STD.StudentResidence = AddressTextBox.Text;
            STD.Qaum = QaumTextBox.Text;
            STD.Religion = ReligionDropdown.Text;
            STD.gender = GenderDropdown.Text;

            StudentValidator validator = new StudentValidator();
            var results = validator.Validate(STD);

            if (results.IsValid == false)
            {

                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage.ToString(), failure.PropertyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                studentAdapter.Insert(STD.StudentImage, STD.AdmissionID, STD.AdmissionDate, STD.StdRollNo, STD.StudentName, STD.FatherName,
                                        STD.FatherMobileNo, STD.StudentDateOfBirth, STD.DateOfBirthInWord, STD.StudentResidence, STD.Qaum,
                                        STD.Religion, STD.sectionID, STD.AdmissionClass, STD.AdmissionSection, STD.gender, STD.age);

                MessageBox.Show("Student's Data Saved:");
                Close();
            }
        }

        private void classdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            STD.AdmissionClass = classdropdown.Text;
            this.sectionTableAdapter.FillBySecWC(this.dataSet.section, STD.AdmissionClass);
            GetRollNoBtn.Visible = true;

        }

        private void secDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            STD.AdmissionSection = secDropdown.Text;
            GetRollNoBtn.Visible = true;
        }


        #region movement

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
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

        #endregion



        private void GetRollNoBtn_Click(object sender, EventArgs e)
        {
            if (STD.AdmissionClass == null && STD.AdmissionSection == null)
            {
                MessageBox.Show("Select Class and section first : ");
            }
            else
            {
                GetRollNoBtn.Visible = false;
                GettingRollNo(STD.AdmissionClass, STD.AdmissionSection);
                if (STD.AdmissionClass != null && STD.AdmissionSection != null)
                {
                    DataSetTableAdapters.sectionTableAdapter sec = new DataSetTableAdapters.sectionTableAdapter();
                    STD.sectionID = (int)sec.SelectSectionID(STD.AdmissionClass, STD.AdmissionSection);
                }


            }

        }


        private void studentPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    studentPicture.Text = openFileDialog1.FileName;
                    studentPicture.Image = Image.FromFile(openFileDialog1.FileName);
                    checker = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                checker = false;
            }
        }

        private void AddNewStudentForm_Load(object sender, EventArgs e)
        {

            this.classesTableAdapter.FillByGroupByclass(this.dataSet.classes);

        }

        private void DOBDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now.Date;

            int currentYear = current.Year;
            DateTime dob = DOBDatePicker.Value.Date;
            int dobYear = dob.Year;
            int age = currentYear - dobYear;
            STD.age = age;
            AgeTextBox.Text = STD.age.ToString();

        }

        private void GenderDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
