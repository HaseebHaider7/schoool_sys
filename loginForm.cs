using SchoolManagementSystem.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        public bool LoginFlag { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        UserAccount User = new UserAccount();


        public LoginForm()
        {
            InitializeComponent();
            LoginFlag = false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            User.username = bunifuTextBox1.Text;
            User.password = bunifuTextBox2.Text;

            DataSetTableAdapters.accountsTableAdapter userAdapter = new DataSetTableAdapters.accountsTableAdapter();
            DataTable dt = userAdapter.GetDataByUsernameAndPass(User.username, User.password);
            if (dt.Rows.Count > 0)
            {
                //Access Granted
                bunifuTextBox1.Text = "";
                bunifuTextBox2.Text = "";
                this.Close();
            }
            else
            {
                //Access Denied
                bunifuTextBox1.Text = "";
                bunifuTextBox2.Text = "";
                MessageBox.Show(User.username + "does not exist or password is inccorect!!");
            }


        }

        private void ClosehoverBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

    }
}


