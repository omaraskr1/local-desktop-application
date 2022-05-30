using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl; User Id=HR; Password = hr";
            string cmdstr = @"select * from PRODUCT WHERE MODEL=:m";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("Model", textBox4.Text.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Product Updated.");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //string constr = "Data source=orcl; User Id=HR; Password = hr";
            //string cmdstr = @"select * from PRODUCT WHERE MODEL=:m";
            //adapter = new OracleDataAdapter(cmdstr, constr);
            //adapter.SelectCommand.Parameters.Add("Model", textBox4.Text.ToString());
            //ds = new DataSet();
            //adapter.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
