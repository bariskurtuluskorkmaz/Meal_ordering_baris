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

namespace Ado.net_CEN_331_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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


        
    }
 }

