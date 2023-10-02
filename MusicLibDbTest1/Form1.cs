using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MusicLibDbTest1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=MusicLibTest2;TrustServerCertificate=true;Trusted_Connection=true";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            if (dbConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Wyebao");
            }

            string s1, s2;
            s1 = materialSingleLineTextField1.Text; s2 = materialSingleLineTextField2.Text;
            //string sql = "INSERT INTO MusicLibSchema1.CdTable(Title,Artist) VALUES ('" + s1 + "','" + s1 + "')";
            string sql = "INSERT INTO MusicLib2Schema.cdTable (Title,Artist) VALUES('" + s1 + "','" + s2 + "')";
            dbConnection.Execute(sql);
            MessageBox.Show("Table updated");
            dbConnection.Close();

            this.Close();

        }
    }
}
