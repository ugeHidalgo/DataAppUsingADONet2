using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAppUsingADONet
{
    public partial class FUsers : Form
    {
        string connString = DataAppUsingADONet.Utilities.GetConnString();
        DataTable usersTempTable = new DataTable();

        public FUsers()
        {
            InitializeComponent();
        }

        private void usersDataGridView_Click(object sender, EventArgs e)
        {
            txtPos.Text = usersDataGridView.CurrentRow.Index.ToString();
        }

        private void FUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainITDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.trainITDataSet.Users);

            txtPos.Text = usersDataGridView.CurrentRow.Index.ToString();
             
            //Manual way
            LoadData(this.dgvUsers);

            setModeNormalForDragging();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                LoadData(dgvUsers);

                this.usersTableAdapter.Fill(this.trainITDataSet.Users);
            }
            else
            {
                LoadData(dgvUsers, txtFirstName.Text);

                this.usersTableAdapter.FillBy (this.trainITDataSet.Users,txtFirstName.Text);
            }
        }

        private DataTable LoadData(DataGridView dgv)
        {//Load data into data grid view: dgvUsers

            DataTable aDataTable = new DataTable(); 
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserMail from Users";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        aDataTable.Load(reader);
                        dgv.DataSource = aDataTable;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                        throw;
                    }
                }
            }
            return aDataTable;
        }

        private void LoadData(DataGridView dgv, string aValue)
        {//Load data into data grid view: dgvUsers
                       
            using (SqlConnection conn = new SqlConnection(connString))
            {                
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserMail from Users where UserFirstName = @userFirstName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userFirstName",SqlDbType.VarChar));
                    cmd.Parameters["@userFirstName"].Value = aValue;


                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgv.DataSource = dataTable;
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                        throw;
                    }
                }
            }
        }

        private void tsBtnShowConnectionString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connString, "Actual Connection String");
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {          
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainITDataSet);

            setModeNormalForDragging();
        }

        private void bnBtnNew_Click(object sender, EventArgs e)
        {
            setModeNewForDragging();
        }

        private void bnBtCancel_Click(object sender, EventArgs e)
        {
            //Reloads data
            this.usersBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.trainITDataSet);

            setModeNormalForDragging();
        }

        private void bnBtDelete_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.trainITDataSet);
            this.usersTableAdapter.Fill(this.trainITDataSet.Users);

            setModeNormalForDragging();
        }

        private void bnBtEdit_Click(object sender, EventArgs e)
        {            
            setModeNewForDragging();
        }

        private void btnLoginCheck_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            if (txtUserLoginCheck.Text == "")
            {
                MessageBox.Show("Falta el usuario");
            }
            else
            {
                //Comprobamos el login.
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string passLeida = txtPassLoginCheck.Text;
                    string query = String.Format(@"select UserName from Users where UserName=@userLeido and PWdCompare('{0}',UserPass)=1",passLeida);
                    using (SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@userLeido", SqlDbType.VarChar));
                        cmd.Parameters["@userLeido"].Value = txtUserLoginCheck.Text;

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            resultado = 50;
                        }
                        reader.Close();
                    }
                }
            }
            if (resultado > 0)
            {
                MessageBox.Show("Acceso Permitido.");
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtUserFirstName.Text = "";
            txtUserSecondName.Text = "";
            dtpUserBDate.Value = DateTime.Now;
            txtUserName.Text = "";
            txtUserPass.Text = "";
            txtUserMail.Text = "";
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            //Load data into data grid view: dgvUsers
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string pass = txtUserPass.Text;
                string query = String.Format(@"insert into Users(UserFirstName, UserSecondName, UserBdate, UserName, UserPass, UserMail)
                                               values(@userFirstName,@userSecondName,@userBDate,@userName,PwdEncrypt('{0}'),@userMail)",
                                               pass);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userFirstName", SqlDbType.VarChar));
                    cmd.Parameters["@userFirstName"].Value = txtUserFirstName.Text;

                    cmd.Parameters.Add(new SqlParameter("@userSecondName", SqlDbType.VarChar));
                    cmd.Parameters["@userSecondName"].Value = txtUserSecondName.Text;

                    cmd.Parameters.Add(new SqlParameter("@userBDate", SqlDbType.Date));
                    cmd.Parameters["@userBDate"].Value = dtpUserBDate.Value.Date;

                    cmd.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar));
                    cmd.Parameters["@userName"].Value = txtUserName.Text;
                    
                    cmd.Parameters.Add(new SqlParameter("@userMail", SqlDbType.VarChar));
                    cmd.Parameters["@userMail"].Value = txtUserMail.Text;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    //Update data in both data grids
                    usersTempTable = LoadData(dgvUsers);
                    this.usersTableAdapter.Fill(this.trainITDataSet.Users);
                }
            }
        }

        private void tsBtnReloadGrids_Click(object sender, EventArgs e)
        {
            //Update data in both data grids
            LoadData(dgvUsers);
            this.usersTableAdapter.Fill(this.trainITDataSet.Users);
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            //Retrieves data to text boxes directly from the Data Grid
     /*       int gridIndex = dgvUsers.CurrentRow.Index;
            txtUserID.Text = dgvUsers[0, gridIndex].Value.ToString();
            txtUserFirstName.Text = dgvUsers[1, gridIndex].Value.ToString();
            txtUserSecondName.Text = dgvUsers[2, gridIndex].Value.ToString();
            dtpUserBDate.Value = Convert.ToDateTime(dgvUsers[3, gridIndex].Value.ToString());
            txtUserName.Text = dgvUsers[4, gridIndex].Value.ToString();
            txtUserMail.Text = dgvUsers[5, gridIndex].Value.ToString();
            */
            
            //Retrieves data to text boxes usin a SQL.
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Take the UserId to find
                int aValue = Convert.ToInt32(dgvUsers[0, dgvUsers.CurrentRow.Index].Value);
                string query = "select UserID, UserFirstName, UserSecondName, UserBdate, UserName, UserPass, UserMail from Users where UserID = @userID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int));
                    cmd.Parameters["@userID"].Value = aValue;

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtUserID.Text = reader.GetInt32(0).ToString();
                            txtUserFirstName.Text = reader.GetString(1);
                            txtUserSecondName.Text = reader.GetString(2);
                            dtpUserBDate.Value = Convert.ToDateTime(reader.GetDateTime(3));
                            txtUserName.Text = reader.GetString(4);
                            txtUserPass.Text = reader.GetSqlBinary(5).ToString();
                            txtUserMail.Text = reader.GetString(6);                            
                        }                        
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("A problem with the User SQL Connection occurs");
                        throw;
                    }
                }
            }

        }

        private void tsBtnPrevious_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow.Index > 0)
            {
                dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.CurrentRow.Index - 1];
                dgvUsers_Click(sender, e);
            }
        }

        private void tsBtnNext_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow.Index < dgvUsers.RowCount-1)
            {
                dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.CurrentRow.Index + 1];
                dgvUsers_Click(sender, e);
            }
        }

        private void tsBtnFirst_Click(object sender, EventArgs e)
        {
            dgvUsers.CurrentCell = dgvUsers[0, 0];
        }

        private void tsBtnLast_Click(object sender, EventArgs e)
        {
            dgvUsers.CurrentCell = dgvUsers[0, dgvUsers.RowCount-1];
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {

        }

        public void setModeNormalForDragging()
        {
            tsBtnReloadGrids.Enabled = true;
            btnFind.Enabled = true;
            btnLoginCheck.Enabled = true;

            bnBtnFirst.Enabled = true;
            bnBtnPrevious.Enabled = true;

            bnPosition.ReadOnly = false;

            bnBtnNext.Enabled = true;
            bnBtnLast.Enabled = true;

            bnBtnNew.Enabled = true;
            bnBtEdit.Enabled = true;
            bnBtDelete.Enabled = true;
            bnBtSave.Enabled = false;                                                          
            bnBtCancel.Enabled = false;

            userFirstNameTextBox.ReadOnly = true;
            userSecondNameTextBox.ReadOnly = true;
            userBDateDateTimePicker.Enabled = false;
            userNameTextBox.ReadOnly = true;
            userMailTextBox.ReadOnly = true;
        }

        public void setModeNewForDragging()
        {
            tsBtnReloadGrids.Enabled = false;
            btnFind.Enabled = false;
            btnLoginCheck.Enabled = false;

            bnBtnFirst.Enabled = false;
            bnBtnPrevious.Enabled = false;

            bnPosition.ReadOnly = true;

            bnBtnNext.Enabled = false;
            bnBtnLast.Enabled = false;

            bnBtnNew.Enabled = false;
            bnBtEdit.Enabled = false;
            bnBtDelete.Enabled = false;
            bnBtSave.Enabled = true;
            bnBtCancel.Enabled = true;

            userFirstNameTextBox.ReadOnly = false;
            userSecondNameTextBox.ReadOnly = false;
            userBDateDateTimePicker.Enabled = true;
            userNameTextBox.ReadOnly = false;
            userMailTextBox.ReadOnly = false;
        }



    }
}
