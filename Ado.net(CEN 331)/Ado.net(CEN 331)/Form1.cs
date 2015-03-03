using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ado.net_CEN_331_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Class.meal.listele();
        }

        public void guncelliste()
        {
            dataGridView1.DataSource = Class.meal.listele();
        }
          
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[satir].Cells["mealID"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells["mealName"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells["mealPrice"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells["categorycategoryID"].Value.ToString();

        }

        public void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "server=HP;database=project;Trusted_Connection=true";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "UPDATE meal SET mealName = @mealName,mealPrice = @mealPrice,categorycategoryID = @categoryID where mealID = @mealID";
            sqlcmd.Parameters.AddWithValue("@mealID", Convert.ToInt32(textBox1.Text));
            sqlcmd.Parameters.AddWithValue("@mealName",textBox2.Text);
            sqlcmd.Parameters.AddWithValue("@mealPrice",Convert.ToDouble(textBox3.Text));
            sqlcmd.Parameters.AddWithValue("@categoryID",textBox4.Text);

            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            guncelliste();
            temizle();

        }

        public void btnyebikayit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "server=HP;database=project;Trusted_Connection=true";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "INSERT INTO meal (mealName,mealPrice,categorycategoryID) VALUES (@mealName,@mealPrice,@categorycategoryID)";
            sqlcmd.Parameters.AddWithValue("@mealName",textBox2.Text);
            sqlcmd.Parameters.AddWithValue("@mealPrice",Convert.ToDouble(textBox3.Text));
            sqlcmd.Parameters.AddWithValue("@categorycategoryID",textBox4.Text);

            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            guncelliste();
            temizle();


        }

        public void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "server=HP;database=project;Trusted_Connection=true";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "DELETE from meal where mealID = @mealID";
            sqlcmd.Parameters.AddWithValue("@mealID", Convert.ToInt32(textBox1.Text));

            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            temizle();
            guncelliste();

        }




        
    }
 }

         