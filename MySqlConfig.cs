using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class MySqlConfig
    {

        public MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=sms_database;persistsecurityinfo=True;allowloadlocalinfile=False;sslmode=None;username=root;password=root@admin");
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataTable dt;
        int result;
        usableFunction funct = new usableFunction();


        public void SearchResults(string sql, DataGridView dgv)
        {
            try
            {

                cmd = new MySqlCommand(sql, con);
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    // MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        public void Deleting_Execute_Query(string sql)
        {
            try
            {
                con.Open();
                MySqlCommand del = new MySqlCommand(sql, con);
                del.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Execute_Query(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void Load_DTG(string sql, DataGridView dtg)
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;


                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }

        public void Load_ResultList(string sql, DataGridView dtg)
        {
            try
            {
                //con.Open();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                dtg.DataSource = dt;


                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }


        public void PopulateCBWithItsValue(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void ComboBoxPopulator(string sql, string text, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.Items.Clear();
                cbo.Text = $"{ text }";
                foreach (DataRow r in dt.Rows)
                {
                    cbo.Items.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }


        public int maxrow(string sql)

        {
            int maxrow = 0;
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                maxrow = dt.Rows.Count;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return maxrow;
        }

        public void autocomplete(string sql, Bunifu.UI.WinForms.BunifuTextBox txt)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

                foreach (DataRow r in dt.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        //public void autonumber(string AUTOKEY, TextBox txt)
        //{
        //    try
        //    {

        //        if (con.State != ConnectionState.Open)
        //        {
        //            con.Open();
        //        }
        //        cmd = new MySqlCommand();
        //        da = new MySqlDataAdapter();
        //        dt = new DataTable();


        //        cmd.Connection = con;
        //        cmd.CommandText = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`='" + AUTOKEY + "'";
        //        da.SelectCommand = cmd;
        //        da.Fill(dt);

        //        txt.Text = DateTime.Now.ToString("yyyy") + dt.Rows[0].Field<string>(0);


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //        da.Dispose();
        //    }
        //}

        //public void trans_autonumber(string AUTOKEY, Label txt)
        //{
        //    try
        //    {

        //        if (con.State != ConnectionState.Open)
        //        {
        //            con.Open();
        //        }
        //        cmd = new MySqlCommand();
        //        da = new MySqlDataAdapter();
        //        dt = new DataTable();


        //        cmd.Connection = con;
        //        cmd.CommandText = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`='" + AUTOKEY + "'";
        //        da.SelectCommand = cmd;
        //        da.Fill(dt);

        //        txt.Text = DateTime.Now.ToString("yyyy") + dt.Rows[0].Field<string>(0);


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //        da.Dispose();
        //    }
        //}
        //public void update_Autonumber(string id)
        //{
        //    Execute_Query("UPDATE `tblautonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" + id + "'");
        //}
    }
}
