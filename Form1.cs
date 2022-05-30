using System;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CrystalReport4 cr;
        CrystalReport2 cr2;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox1.Text);
			crystalReportViewer1.ReportSource = cr2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cr = new CrystalReport4();
            cr2 = new CrystalReport2();
            foreach (ParameterDiscreteValue x in cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(x.Value.ToString());
            }
        }
    }
}
