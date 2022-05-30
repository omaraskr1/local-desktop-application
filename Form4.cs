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
    public partial class Form4 : Form
    {


        string ordb = "Data source=orcl; User Id=HR; Password = hr";
        OracleConnection conn;

        public Form4()  
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CUSTOMERID from FINALPHOTO";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_id.Items.Add(dr[0]);
            }
            dr.Close();

        }
        private void Form1_Formclosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select CUSTOMERNAME from FINALPHOTO where CUSTOMERID =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("CUSTOMERID", cmb_id.SelectedItem.ToString());

            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();

            }
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into CUST values(:id,:name)";
            cmd.Parameters.Add("CUSTOMERID", cmb_id.Text);
            cmd.Parameters.Add("CUSTOMERNAME", textBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_id.Items.Add(cmb_id.Text);
                MessageBox.Show("New Customer Added");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "NEWUSER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CNAME", textBox1.Text);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());
            }
            dr.Close();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETUSER";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("name", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("x", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("z", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("W", cmb_id.Text.ToString());
            cmd.ExecuteNonQuery();
            listView1.Items.Add(cmd.Parameters["name"].Value.ToString());
            listView1.Items.Add(cmd.Parameters["x"].Value.ToString());
            listView1.Items.Add(cmd.Parameters["z"].Value.ToString());

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
