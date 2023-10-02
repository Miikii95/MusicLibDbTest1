using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibDbTest1
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicLibTest2DataSet.cdTable' table. You can move, or remove it, as needed.
            this.cdTableTableAdapter.Fill(this.musicLibTest2DataSet.cdTable);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.cdTableTableAdapter.Fill(this.musicLibTest2DataSet.cdTable);

        }   

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
        }


    }
    }


