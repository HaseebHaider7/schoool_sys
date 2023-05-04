
using System;
using System.Drawing;
using System.Windows.Forms;


namespace SchoolManagementSystem
{
    public partial class Dashboard : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Dashboard()
        {
            //LoginForm login = new LoginForm();
            //login.ShowDialog();
            InitializeComponent();
            openChildForm(new homeForm());
        }

        #region maximizing
        private void resBtn_Click_1(object sender, EventArgs e)
        {
            maxiBtn.Visible = true;
            resBtn.Visible = false;
            WindowState = FormWindowState.Normal;
        }
        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxiBtn_Click(object sender, EventArgs e)
        {
            maxiBtn.Visible = false;
            resBtn.Visible = true;
            WindowState = FormWindowState.Maximized;
            
        }
        private void bunifuGradientPanel1_DoubleClick(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                maxiBtn.Visible = false;
                resBtn.Visible = true;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                maxiBtn.Visible = true;
                resBtn.Visible = false;
                WindowState = FormWindowState.Normal;
            }
        }
        private void closehoverBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            new aboutForm().ShowDialog();
        }



        #endregion



        private void homeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new homeForm());
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new staffForm());
        }

        private void stdBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentForm());
        }

        private void atdBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new attendenceForm());
        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new subjectForm());
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ClassroomForm());
        }

        private void secBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new sectionForm());
        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new resultForm());
        }

        private void feeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new FeeForm());
        }

        private void desBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new staffDesignationForm());
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHome.Controls.Add(childForm);
            panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

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

       
    }
}
