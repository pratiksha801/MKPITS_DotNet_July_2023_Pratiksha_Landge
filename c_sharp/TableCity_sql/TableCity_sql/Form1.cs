using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TableCity_sql
{
    public partial class Form1 : Form
    {
        string strcon = "server=USER\\SQLEXPRESS;integrated security=true;database=course_registration ";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tablenation order by nation_id ", con);
                ds = new DataSet();
                da.Fill(ds, "tablenation");
                comboBox1.DataSource = ds.Tables["tablenation"];
                comboBox1.DisplayMember = "nation_name";
                comboBox1.ValueMember = "nation_id";

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }


        }
      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablestate  where nation_id=@nation_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@nation_id", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "state_name";
                    comboBox2.ValueMember = "state_id";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablecity  where state_id=@state_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@state_id", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "city_name";
                    comboBox3.ValueMember = "city_id";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
    }
}

