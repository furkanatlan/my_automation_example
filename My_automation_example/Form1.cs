using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_automation_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerDbContext db = new CustomerDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var customers = db.Customers.ToList();
                dataGridView1.DataSource = customers;

                // Sütun başlıklarını değiştirme
                dataGridView1.Columns["Customer_Id"].HeaderText = "Müşteri ID";
                dataGridView1.Columns["Customer_Name"].HeaderText = "Müşteri Adı";
                dataGridView1.Columns["Customer_Surname"].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns["Customer_Email"].HeaderText = "E-Posta";
                dataGridView1.Columns["Customer_Telephone"].HeaderText = "Telefon";

                dataGridView1.Columns["Customer_Id"].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }



        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer()
                {
                    Customer_Name = txt_isim.Text,
                    Customer_Surname = txt_soyisim.Text,
                    Customer_email = txt_email.Text,
                    Customer_telephone = txt_telefon.Text
                };

                db.Customers.Add(newCustomer);
                db.SaveChanges();

                MessageBox.Show("Kayıt İşlemi Başarılı!");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata = {ex.Message}");
            }

        }
    }
}
