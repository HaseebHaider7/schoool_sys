
using SchoolManagementSystem.DataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class attendenceForm : Form
    {

        string classes, section;
        DateTime date;
        DateTime today, previousday;
        int calVal = 0;
        attendencetbTableAdapter adapter = new attendencetbTableAdapter();

        
        public attendenceForm()
        {
            InitializeComponent();
            
        }

        public int dayscalculator()
        {
            today = DateTime.Now.Date;
            previousday = DatePicker.Value.Date;
            int age = (today - previousday).Days;

            return age;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

            calVal = dayscalculator();
            if (calVal > 5)
            {
                MessageBox.Show("Days Limitor exceeding");
            }
            else
            {

                foreach (DataGridViewRow row in attendenceDataGridView.Rows)
                {

                    if (row.Cells[0].Value != null)
                    {
                        adapter.UpdateQuery(row.Cells[0].Value, row.Cells[1].Value.ToString(), classes, section, date);
                    }
                }
            }

            DataTable dt_new = adapter.GetDataBy(classes, section, date);

            attendenceDataGridView.DataSource = dt_new;

        }

        private void classdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            classes = classdropdown.Text;
            if (classes != null)
            {
                this.sectionTableAdapter.FillBySecWC(this.dataSet.section, classes);
            }
        }

        private void secDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            section = secDropdown.Text;
        }

        private void attendenceForm_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.FillBySortedClass(this.dataSet.classes);
            // modifying as dashboard need to be done
            this.DatePicker.Value = DateTime.Now;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            classes = classdropdown.Text;
            section = secDropdown.Text;
            date = DatePicker.Value.Date;

           if(classdropdown.Text != "Select Class" && secDropdown.Text != "Select Section" &&
                classdropdown.Text != null && secDropdown.Text != null)
           {
                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    DataTable dt = adapter.GetDataBy(classes, section, date);

                    if (dt.Rows.Count > 0)
                    {
                        //we have record
                        DataTable dt_new = adapter.GetDataBy(classes, section, date);
                        attendenceDataGridView.DataSource = dt_new;
                    }
                    else
                    {
                        int attendence = 0;
                        //creating record for each student
                        //getting student list by class
                        studentTableAdapter studentAdapter = new studentTableAdapter();

                        DataTable stdDT = studentAdapter.GetDataByClassAndSection(classes, section);

                        if (stdDT.Rows.Count > 0)
                        {
                            foreach (DataRow row in stdDT.Rows)
                            {
                                //Inserting new data
                                adapter.InsertQuery(attendence, row[4].ToString(), (int)row[3], row[1].ToString(), (int)row[16], classes, section, date);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No student record in the given section");
                        }
                        DataTable dt_new = adapter.GetDataBy(classes, section, date);
                        attendenceDataGridView.DataSource = dt_new;
                    }
                }
                else
                {
                    MessageBox.Show("Today is Holiday:","Sunday Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
           }
           else
           {
               MessageBox.Show("Please Select Class And Section:");
           }
        }
    }
}
