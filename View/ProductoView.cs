using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaPracticaCoperex.View
{
    public partial class ProductoView : Form, IProductoView
    {
        public ProductoView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
        }       

        public string ProductoID {
            get => ProductoID;
            set => ProductoID = value; 
        }
        public string ProductoNombre {
            get => ProductoNombre;
            set => ProductoNombre = value;
        }
        public string ProductoDescripcion {
            get => ProductoDescripcion;
            set => ProductoDescripcion = value;
        }
        public string ProductoStock {
            get => ProductoStock;
            set => ProductoStock = value;
        }
        public string ProductoPrecio { 
            get => ProductoPrecio; 
            set => ProductoPrecio = value; 
        }
        public bool IsEdit { 
            get => IsEdit; 
            set => IsEdit = value; 
        }
        public bool IsSuccesful {
            get => IsSuccesful;
            set => IsSuccesful = value;
        }
        public string Message {
            get => Message;
            set => Message = value;
        }

        public event EventHandler AgregarProductoEvento;
        public event EventHandler EditarProductoEvento;
        public event EventHandler EliminarProductoEvento; 
        public event EventHandler GuardarEvento;
        public event EventHandler CancelarEvento;


        public void SetProductoListBindingSource(BindingSource productoList)
        {
            dataGridView1.DataSource = productoList;
        }
    }
}
