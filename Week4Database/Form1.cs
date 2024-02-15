using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;database=week4;username=root;password=";
                //Display query
                string Query = "select * from contacts;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                   // MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;database=week4;username=root;password=";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = $"insert into contacts(ContactID,Firstname,Lastname,AllowByContact,DOB,CreatedDate) values(" + contactID.Text +",'"+ frstName.Text + "','" + lastName.Text + "'," + (allowContact.Checked?1:0) + ",'" + DOB.Text + "','" + createdDate.Text+"');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;database=week4;username=root;password=";
                string Query = "delete from contacts where ContactID='" + contactID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;database=week4;username=root;password=";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update contacts set ContactID='" + contactID.Text + "',Firstname='" + frstName.Text + "',Lastname='" + lastName.Text + "',DOB='" + DOB.Text + "',AllowByContact=" + (allowContact.Checked?1:0) + ", CreatedDate='" + createdDate.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
