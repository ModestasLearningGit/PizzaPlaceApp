using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaPlace
{
    public partial class NewOrder : Form
    {

        public static SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        string extraCheese = "No";
        string fatPad = "No";
        public NewOrder()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source = DESKTOP-OSTDV7J; Initial Catalog = pizzaPlace; User ID = admin; Password = 123456");
            display();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnAddorder_Click(object sender, EventArgs e)
        {

            if(chbExtraCheese.Checked)
            {
                extraCheese = "Yes";
            }
            else
            {
                extraCheese = "No";
            }
            if(chbFatPad.Checked)
            {
                fatPad = "Yes";
            }
            else
            {
                fatPad = "No";
            }
            if(txtCustomerName.Text == "" || txtPizzaName.Text == "")
            {
                MessageBox.Show("Please fill all text fields");
            }
            else
            {
               try
               {
                    con.Open();
                    cmd = new SqlCommand("Insert into Neworder (CustomerName, PizzaType,  ExtraCheese, FatPad) values('" + txtCustomerName.Text + "','" + txtPizzaName.Text + "','" + extraCheese + "','" + fatPad + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order inserted sucesfuly");
                    clear();
                    display();
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //My functions
        public void clear()
        {
            txtCustomerName.Text = "";
            txtPizzaName.Text = "";
        }
        public void display()
        {
            try
            {
                dt = new System.Data.DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM NewOrder", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
