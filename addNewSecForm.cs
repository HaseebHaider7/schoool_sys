using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class addNewSecForm : Form
    {
        MySqlConfig MSC = new MySqlConfig();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public addNewSecForm()
        {
            InitializeComponent();
        }
        sectionForm sc = new sectionForm();
        private void saveBtn_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.sectionTableAdapter SectionAdapter = new DataSetTableAdapters.sectionTableAdapter();
            if (classdropdown.Text == string.Empty || secDropdown.Text == string.Empty)
            {
                MessageBox.Show("Please select class and section");
            }
            else
            {
                DataTable dt = SectionAdapter.GetDataByUniqueSec(classdropdown.Text, secDropdown.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Section Already Exist:", "Duplicate Section", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SectionAdapter.AddSection(classdropdown.Text, secDropdown.Text);
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
