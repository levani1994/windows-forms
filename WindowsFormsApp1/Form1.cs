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

        public Form1()
        {

            InitializeComponent();
            GridFill();
            ComboFill();
        }

        public void GridFill()
        {

            List<User> UsersList = new List<User>();

            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = @"select [ID]
                                   ,[Name]
                                   ,[Surname]
                                   ,[Birthdate]
                                   ,[CreateDate] 
                                from [Users]
                                    order by CreateDate desc";
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
                    UsersList.Add(user);

                }
                conn.Close();
                UsersGridView.DataSource = UsersList;
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

        public void ComboFill()
        {
            // List<Groups> GroupList = new List<Groups>();

            SqlConnection conn = new SqlConnection(connection);


            string query = @"select ID, Name from Groups";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {

                GroupsList.Items.Clear();
                conn.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Groups groups = new Groups();
                    groups.Name = Reader["Name"].ToString();
                    groups.ID = Convert.ToInt32(Reader["ID"]);
                    GroupsList.Items.Add(new KeyValuePair<int, string>(groups.ID, groups.Name));
                    //  GroupList.Add(groups);





                }
                conn.Close();


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

        public bool IsEmptyString(string name, string surname)
        {
            var IsValid = false;
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                IsValid = true;
            }
            return IsValid;

        }

        public void AddUser(string Name, string Surname, string Group, DateTime Birthdate)
        {

            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = "INSERT INTO [Users](Name, Surname, Birthdate, CreateDate, GroupID)" + " values (@name, @surname, @birthdate, @createDate)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Name;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar, 50).Value = Surname;
                    cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = Birthdate;
                    cmd.Parameters.Add("@createDate", SqlDbType.DateTime).Value = DateTime.Now;

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


        public void AddGroup(string GroupName)
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = "insert into Groups (Name) values (@groupName)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar, 50).Value = GroupName;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                // comboBox1.Items.Add(Group.Name);

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


        public void UpdateUser(int id, string Name, string surname, DateTime birthdate)
        {

            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                string query = @"UPDATE Users SET
                              Name = @name,
                              Surname = @surname,
                              Birthdate = @birthdate
                              where ID = " + id + " ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Name;
                    cmd.Parameters.Add("@surname", SqlDbType.NVarChar, 50).Value = surname;
                    cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
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


        private void BtnAddUser_Click(object sender, EventArgs e)
        {

            string name = UserName.Text;
            string surname = UserLastName.Text;
            //string group = GroupsList


            //DateTime birthdate = DtBirthdate.Value;

            //if (IsEmptyString(name, surname))
            //{
            //    AddUser(name, surname, group, birthdate);
            //    GridFill();
            //}
            //else
            //{
            //    MessageBox.Show("sheavset carieli velebi");
            //}


        }

        private void UsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var item = e.RowIndex;
            DataGridViewRow selectedRow = UsersGridView.Rows[item];
            int userId = Convert.ToInt32(selectedRow.Cells[0].Value);
            UserId = userId;
            //  MessageBox.Show(userId.ToString());
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            string query = @"SELECT
                               [Name]
                              ,[Surname]
                              ,[Birthdate]
                              FROM[User].[dbo].[Users]
                              where
                               [ID] = " + userId + " ";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserName.Text = reader["Name"].ToString();
                UserLastName.Text = reader["Surname"].ToString();
                DtBirthdate.Value = Convert.ToDateTime(reader["Birthdate"]);
            }
            sqlConnection.Close();



        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {

            string name = UserName.Text;
            string surname = UserLastName.Text;
            DateTime birthdate = DtBirthdate.Value;
            if (IsEmptyString(name, surname))
            {
                UpdateUser(UserId, name, surname, birthdate);
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
            if (!string.IsNullOrWhiteSpace(groupName))
            {
                AddGroup(groupName);
                ComboFill();
                Group.Clear();
            }
            else
            {
                MessageBox.Show("sheavset carieli velebi");
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

    }
}

public class Groups
{
    public int ID { get; set; }
    public string Name { get; set; }

}
