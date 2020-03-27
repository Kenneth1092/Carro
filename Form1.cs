using System; 
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
  
namespace Carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        } 
       // SoundPlayer Encender = new SoundPlayer(@"D:\carroMisc\audio\accelerating.wav");
        //int num = 0;
 
        
        //Thread t1,t2;
    

        /*
        int next, previous = 1;
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        Object precio, fecha;*/

        private void button3_Click(object sender, EventArgs e)
        {
           // SoundPlayer Encender = new SoundPlayer(@"D:\carroMisc\audio\engine.wav");
            //   Encender.Play();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // SoundPlayer Encender = new SoundPlayer(@"D:\carroMisc\audio\AC.wav");
           // Encender.Play();
        }

    

        private void button1_Click(object sender, EventArgs e)
        { 
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
 
         
       
        }

        public void thread1()
        {
         //   int num;
          //  num = Encender.LoadTimeout;

           
         //   for (int i = 0; i <= num; i++)
            {
               
           //     Encender.Play();
           //     Thread.Sleep(num);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
         //   t1.Abort();
           // t2.Abort();
          //  Encender.Stop();
           
          //  this.num = 0;
         
        }
     

        private void carrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDataSet.carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.carsDataSet.carros);
            // TODO: This line of code loads data into the 'carsDataSet.carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.carsDataSet.carros);

        }

        private void carrosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.carrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (comboBox1.SelectedItem == "Honda")
                {
                   
                    cmd1.Connection = con;
                     cmd2.Connection = con; 
                     cmd1.CommandText = "SELECT Precio FROM carros WHERE ID = 1" +  next.ToString();
                     cmd2.CommandText = "SELECT Fecha FROM carros WHERE ID = 1"  

                    //DataTable data = new DataTable();
                    // SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.Fill(data);
                    //dataGridView1.DataSource = data;

                      precio = cmd1.ExecuteScalar();
                        fecha = cmd2.ExecuteScalar();

                    lblPrecio.Text = dollar+ precio.ToString();
                     
                    lblFecha.Text =  fecha.ToString();
                    */

                

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            //Se crea un segundo form
            compra formCompra = new compra(this);
         
           formCompra.ShowDialog();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            VerCompras formCompra = new VerCompras();

           
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ADMINISTRADOR\SQLEXPRESS;Initial Catalog=cars;Integrated Security=True");

            string query = "select * from Users where Users = '" + UserTxt.Text.Trim() + "' and Pass = '" + PassTxt.Text.Trim()+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                formCompra.ShowDialog();
                 
            }
            else
            {
                MessageBox.Show("El usuario Es Kenneth y el pass Diaz");
            }


           // formCompra.ShowDialog();
             
        }

     

}
}
