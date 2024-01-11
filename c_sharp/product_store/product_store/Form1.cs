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
using System.Data.SqlClient;

namespace product_store
{
    public partial class Form1 : Form
    {
        public enum Nationality { Indian, NRI }
        Nationality nat;

        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=project store";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show("control key " + char.IsControl(e.KeyChar).ToString());
            //  MessageBox.Show("digit key "+char.IsDigit(e.KeyChar).ToString());
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getcategory();
            getproduct();
            getprice();
        }
        public void getcategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from tableproductcategory", con);
            ds = new DataSet();
            da.Fill(ds, "tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getproduct();
        }
        public void getproduct()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tableproduct where product_category_id=@pci", con);
                da.SelectCommand.Parameters.AddWithValue("@pci", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp");
                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "product_name";
                comboBox2.ValueMember = "product_id";


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
        }
        public void getprice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tableproduct where product_id=@pid", con);
                da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp1");
                foreach (DataRow dr in ds.Tables["tp1"].Rows)
                {
                    textBox9.Text = dr["product_price"].ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                nat = Nationality.Indian;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nat = Nationality.NRI;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                double price = Convert.ToDouble(textBox9.Text);
                double quantity = Convert.ToDouble(textBox10.Text);
                double totalamount = price * quantity;
                textBox11.Text = totalamount.ToString();
            }

        }

    }

}
