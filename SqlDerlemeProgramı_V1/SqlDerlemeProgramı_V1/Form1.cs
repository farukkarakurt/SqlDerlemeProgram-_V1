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

namespace SqlDerlemeProgramı_V1
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=FARUK\\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        private void btn_execute_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("İşleminiz gerçekleşmedi. Kontrol edin.");
            }
        }
        private void btn_ekleSilGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = richTextBox1.Text;

                conn.Open();
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_matematik", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("İşleminiz gerçekleşmedi. Kontrol edin.");
            }
            
        }
    }
}
