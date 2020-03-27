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

namespace Carro
{
    public partial class compra : Form
    {
        Form1 fr1;
        public compra(Form1 fr1)
        {
            InitializeComponent();
            
            this.fr1 = fr1;
            //MessageBox.Show(fr1.iDTextBox.Text);
        }
     
        SqlConnection con = new SqlConnection("Data Source=ADMINISTRADOR\\SQLEXPRESS;Initial Catalog=cars;Integrated Security=True");
         
        public bool nulo(string SS)
        {

            //Verifica si es nulo o hay un espacio en blanco
            return string.IsNullOrWhiteSpace(SS);
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (!nulo(NameTxt.Text) && !nulo(ApeTxt.Text) && !nulo(DirTxt.Text) && !nulo(PaisTxt.Text))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into compras(ID, Nombre, Apellido,Carro, Precio, Dirección, Dirección2, Pais,Fecha ) values ('" + int.Parse(fr1.iDTextBox.Text) + "','" + NameTxt.Text + "','" + ApeTxt.Text
                    + "','" + fr1.marcaTextBox.Text + "','" + fr1.precioTextBox.Text + "','" + DirTxt.Text + "','" + Dir2Txt.Text + "','" + PaisTxt.Text + "','" + fr1.fechaTextBox.Text + "')", con);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Saved");

                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();
            }
            else
            {

                
                MessageBox.Show("Error: Texto en blanco");

                return;
                 
            }

        } 

        private void NameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }
 //Los siguientes metodos funcionan para que no hayan espacios, ni numeros en los textos
        private void ApeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void compra_Load(object sender, EventArgs e)
        {

        }

        private void DirTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PaisTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
