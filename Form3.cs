using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace crytsal_reports_task
{
	public partial class Form1 : Form
	{
		CrystalReport1 cr;
		CrystalReport2 cr2;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cr = new CrystalReport1();
			cr2 = new CrystalReport2();
			foreach(ParameterDiscreteValue x in cr.ParameterFields[1].DefaultValues)
			{
				comboBox1.Items.Add(x.Value);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cr.SetParameterValue(1, comboBox1.Text);
			crystalReportViewer1.ReportSource = cr;
		
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			//cr = new CrystalReport1();
			//foreach (ParameterDiscreteValue x in cr.ParameterFields[0].DefaultValues)
			//{
			//	comboBox1.Items.Add(x.Value);
			//}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cr2.SetParameterValue(0, comboBox1.Text);
			crystalReportViewer1.ReportSource = cr2;
		}
	}
}
