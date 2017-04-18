using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_v3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void payrollBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.payrollBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database7DataSet);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database7DataSet.payroll' table. You can move, or remove it, as needed.
			this.payrollTableAdapter.Fill(this.database7DataSet.payroll);

		}

		private void payrollDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			payrollBindingSource.AddNew();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			payrollBindingSource.MovePrevious();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			payrollBindingSource.MoveNext();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			payrollBindingSource.RemoveCurrent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.payrollBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database7DataSet);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.payrollBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database7DataSet);
		}

		private void button4_Click(object sender, EventArgs e)
	{
			DateTime Timeofday = DateTime.Now;
	// txtReceipt.text = "";
    //	txtReceipt.AppendText(" " + Environment.NewLine);
	//	txtReceipt.AppendText("\t\t\t\tPay Slip " + Environment.NewLine);
	//		txtReceipt.AppendText("====================" + Environment.NewLine);
	//	txtReceipt.AppendText("\t\t\t\t\t Hello" + Environment.NewLine);
	//		txtReceipt.AppendText("==================== /n");
	//	txtReceipt.AppendText(Environment.NewLine);

	//	txtReceipt.AppendText("worker name: " + "\t" + worker_nameTextBox + "\t\t\t" + company_nameTextBox + Environment.NewLine)
	//	txtReceipt.AppendText("adress: " + "\t" + addressTextBox + Environment.NewLine);
	//		txtReceipt.AppendText("zipcode: " + "\t" + zipcodeTextBox + Environment.NewLine);
	//	txtReceipt.AppendText("====================" + Environment.NewLine);

	//	txtReceipt.AppendText("pay: " + "\t" + payTextBox + Environment.NewLine);
//	txtreceipt.AppendText("overtime: " + "\t" + overtimeTextBox + Environment.NewLine);
	//		txtReceipt.AppendText("total pay: " + "\t" + total_payTextBox + Environment.NewLine);



		}
	}
}
