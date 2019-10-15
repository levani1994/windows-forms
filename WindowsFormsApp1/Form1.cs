using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        int UserId;
        List<KeyValuePair<int, string>> ComboSource = new List<KeyValuePair<int, string>>();
        public Form1()
        {

            InitializeComponent();
            GridFill();
            ComboFill();
        }

        private void GridFill()
        {

            List<User> UsersList = new List<User>();

            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = @"select
                                    U.ID,
                                    U.Name, 
                                    U.Surname, 
                                    U.Birthdate,
                                    U.CreateDate, 
                                    G.GroupName
                                from Users U
                                LEFT JOIN Groups G on U.GroupID=G.ID
                                order by U.CreateDate desc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    User user = new User();
                    user.ID = Convert.ToInt32(Reader["ID"]);
                    user.Name = Reader["Name"].ToString();
                    user.Surname = Reader["Surname"].ToString();
                    user.BirthDate = Convert.ToDateTime(Reader["Birthdate"]);
                    user.CreateDate = Convert.ToDateTime(Reader["CreateDate"]);
                    user.GroupName = Reader["GroupName"].ToString();
                    UsersList.Add(user);

                }

                UsersGridView.DataSource = UsersList;
                UsersGridView.Columns["ID"].Visible = false;
            }
            catch (Exception e)
            {

                MessageBox.Show("შეცდომა მონაცემების დამუშავების დროს: " + e.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        public void ComboFill()
        {

            SqlConnection conn = new SqlConnection(connection);
            string query = @"select ID, GroupName from Groups";
            SqlCommand cmd = new SqlCommand(query, conn);

            ComboGroupsList.DataSource = null;
            ComboGroupsList.Items.Clear();
            ComboSource = new List<KeyValuePair<int, string>>();

            try
            {
                conn.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {

                    Group group = new Group();
                    group.Name = Reader["GroupName"].ToString();
                    group.ID = Convert.ToInt32(Reader["ID"]);
                    ComboSource.Add(new KeyValuePair<int, string>(group.ID, group.Name));


                }


                ComboGroupsList.ValueMember = "key";
                ComboGroupsList.DisplayMember = "Value";
                ComboGroupsList.DataSource = ComboSource;




            }
            catch (Exception e)
            {

                MessageBox.Show("შეცდომა მონაცემების დამუშავების დროს: " + e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public bool VlidateUserViewModel(string name, string surname)
        {
            var IsValid = false;
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                IsValid = true;
            }
            return IsValid;

        }

        public void AddUser(string Name, string Surname, DateTime Birthdate, int GroupID)
        {

            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = "INSERT INTO [Users](Name, Surname, Birthdate, CreateDate, GroupID)" + " values (@name, @surname, @birthdate, @createDate, @GroupID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Name;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar, 50).Value = Surname;
                    cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = Birthdate;
                    cmd.Parameters.Add("@createDate", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@GroupID", SqlDbType.Int).Value = GroupID;
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void AddGroup(string GroupName)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = "insert into Groups (GroupName) values (@groupName)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar, 50).Value = GroupName;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void UpdateUser(int id, string Name, string surname, DateTime birthdate, int GroupID)
        {

            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = $@"UPDATE Users SET
                              Name = @name,
                              Surname = @surname,
                              Birthdate = @birthdate,
                              GroupID = @GroupID
                              where ID =  {id} ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Name;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar, 50).Value = surname;
                    cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                    cmd.Parameters.Add("@GroupID", SqlDbType.Int).Value = GroupID;
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }


        }


        private void BtnAddUser_Click(object sender, EventArgs e)
        {

            string Name = UserName.Text;
            string Surname = UserLastName.Text;
            int GroupId = ((KeyValuePair<int, string>)ComboGroupsList.SelectedItem).Key;
            DateTime Birthdate = DtBirthdate.Value;

            if (VlidateUserViewModel(Name, Surname))
            {
                AddUser(Name, Surname, Birthdate, GroupId);
                GridFill();
            }
            else
            {
                MessageBox.Show("sheavset carieli velebi");
            }


        }

        private void UsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var item = e.RowIndex;
            DataGridViewRow selectedRow = UsersGridView.Rows[item];
            UserId = Convert.ToInt32(selectedRow.Cells[0].Value);

            SqlConnection sqlConnection = new SqlConnection(connection);

            string query = $@"SELECT
                                U.Name,
                                U.Surname, 
                                U.Birthdate,
                                U.GroupID
                            from Users U 
                                inner JOIN Groups G on U.GroupID=G.ID
                            where
                               U.ID = {UserId} ";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserName.Text = reader["Name"].ToString();
                    UserLastName.Text = reader["Surname"].ToString();
                    DtBirthdate.Value = Convert.ToDateTime(reader["Birthdate"]);
                    ComboGroupsList.SelectedItem = ComboSource.Find(Item => Item.Key == Convert.ToInt32(reader["GroupID"]));
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();

            }




        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {

            string name = UserName.Text;
            string surname = UserLastName.Text;
            DateTime birthdate = DtBirthdate.Value;
            int GroupId = ((KeyValuePair<int, string>)ComboGroupsList.SelectedItem).Key;
            if (VlidateUserViewModel(name: name, surname: surname))
            {
                UpdateUser(UserId, name, surname, birthdate, GroupId);
                UserName.Clear();
                UserLastName.Clear();
                DtBirthdate.ResetText();
                Group.Clear();
                GridFill();
            }
            else
            {
                MessageBox.Show("sheavset carieli velebi");

            }



        }

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = Group.Text;
            if (string.IsNullOrWhiteSpace(groupName))
            {

                MessageBox.Show("sheavset carieli velebi");
            }
            else
            {

                AddGroup(GroupName: groupName);
                ComboFill();
                Group.Clear();
            }
        }


    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string GroupName { get; set; }

    }


    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
