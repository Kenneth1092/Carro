using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class VerCompras : Form
    {
        public VerCompras()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compras);

        }

        private void VerCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'compras._compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter.Fill(this.compras._compras);

        }

        private void comprasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
