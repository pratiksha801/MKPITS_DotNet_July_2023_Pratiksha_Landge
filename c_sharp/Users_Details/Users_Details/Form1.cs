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

namespace Users_Details
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true;database=course_registration"; 
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            getnation();
            getstate();
            getcity();

            if (radioButton1.Checked)
                textBox2.Text = "1000";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getstate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcity();
        }
        public void getnation()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableNation2 order by nation_id ", con);
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

        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState2  where nation_id=@nation_id", con);
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
        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableCity1  where state_id=@state_id", con);
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
        public enum category { student, it_professional }
        public enum gender { male, female, other }

        category cat;
        gender gen;


        private void button1_Click(object sender, EventArgs e)
        {

            // Get the selected payment date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;

            // Validate that the selected date is not earlier than today
            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("");
                //MessageBox.Show("Please select a payment date that is on or after today's date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("full name cant be blank");
            }
            else
            {
                //for category
                if (radioButton1.Checked)
                {
                    cat = category.student;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.it_professional;
                }
                MessageBox.Show("category " + cat);
                //for gender
                if (radioButton3.Checked)
                {
                    gen = gender.male;
                }
                else if (radioButton4.Checked)
                {
                    gen = gender.female;
                }
                else if (radioButton5.Checked)
                {
                    gen = gender.other;
                }
                //  MessageBox.Show("gender selected " + gen);
                //code to save record in courseregdetail table
                savecourseregdetail(cat, gen);
            }


        }

        public void savecourseregdetail(category c, gender g)
        {
            try
            {
                string str = "insert into tablecourseregdetail values(@categoryid,@fullname,@genderid)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@categoryid", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@fullname", textBox1.Text);
                command.Parameters.AddWithValue("@genderid", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                //   MessageBox.Show("record saved");
                con.Close();
                insertRegAddress();

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        public void insertRegAddress()
        {



            con.Open();

            string str = "select max(courseregid) from tablecourseregdetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());
            // MessageBox.Show(mcid.ToString());
            string s2 = "insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd1.Parameters.Add("@StateID", SqlDbType.Int).Value = comboBox2.SelectedValue;
            cmd1.Parameters.Add("@CityID", SqlDbType.Int).Value = comboBox3.SelectedValue;
            cmd1.ExecuteNonQuery();
            // con.Close();
            MessageBox.Show("Stored TableRegAddress");


            con.Close();
            insertFeeDetail();
        }

        public void insertFeeDetail()
        {

            con.Open();

            string str = "select max(courseregid) from tablecourseregdetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());

            string s2 = "insert into TableFeeDetail values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = textBox2.Text;
            cmd1.Parameters.Add("@MinPer", SqlDbType.Int).Value = fp;
            cmd1.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = textBox3.Text;
            cmd1.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox4.Text;
            cmd1.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetail");
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
                // calculatefees();
            }
        }
        float fp = 0;
        float bamt = 0;
        public void calculatefees()
        {
            if (cat.ToString() == "student")
            {
                textBox2.Text = "1000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "it_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cat = category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
                //  calculatefees();
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                cat = category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
                //  calculatefees();
            }
        }
        public void clear()
        {
            getnation();
            getstate();
            getcity();
            radioButton1.Checked = true;
            
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text=string.Empty;
            textBox2.Text=string.Empty;
            textBox3.Text=string.Empty;
            textBox4.Text=string.Empty;
            dateTimePicker1 = new DateTimePicker();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}




