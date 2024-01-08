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

namespace loginformforado
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; set; } = @"Data Source =.\sqlexpress;Initial Catalog = adoserver;Integrated Security=true;";
        SqlDataAdapter Sqlda;
        DataSet dataSet;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            Sqlda =new SqlDataAdapter("Select * from EmployeeDetails",ConnectionString);
            cb = new SqlCommandBuilder(Sqlda);
            dataSet = new DataSet();
            Sqlda.Fill(dataSet, "Emp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dataSet.Tables["emp"];
            comboBox1.DisplayMember = "EmpID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //steps to insert record in disconnected env
            //create a new row using datarow object
            DataRow dr = dataSet.Tables["Emp"].NewRow();
            //add values to newly created datarow
            dr[0] = textBox1.Text;
            dr[1]= textBox2.Text;
            dr[2]= textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4]= textBox5.Text;
            dr[5] = Convert.ToInt32(textBox6.Text);
            dr[6] = Convert.ToInt32(textBox7.Text);
            //add the newly created row to datatable
            dataSet.Tables["Emp"].Rows.Add(dr);
            //using update add the new row to sqlserver database table
            Sqlda.Update(dataSet.Tables["Emp"]);
            MessageBox.Show("Data Sucessfully Inserted..");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Emp"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString()==textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = Convert.ToInt32(textBox6.Text);
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        Sqlda.Update(dataSet.Tables["Emp"]);
                        MessageBox.Show("Data sucessfully updated....");

                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString()==textBox1.Text)
                {
                    try
                    {
                        dataSet.Tables["Emp"].Rows.Remove(dr);
                        Sqlda.Update(dataSet.Tables["Emp"]);
                        MessageBox.Show("Data successfully Deleted....");
                    }
                    catch (Exception ee) 
                    {
                        MessageBox.Show(ee.Message);
                    }
                    break;
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empid = comboBox1.Text;
            MessageBox.Show(empid);
        }
    }

}
