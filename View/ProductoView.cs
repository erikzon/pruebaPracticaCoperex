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
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCrud);
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonAgregar.Click += delegate { 
                AgregarProductoEvento?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageLectura);
                tabControl1.TabPages.Add(tabPageCrud);
            };
            buttonEditar.Click += delegate { 
                EditarProductoEvento?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageLectura);
                tabControl1.TabPages.Add(tabPageCrud);
            };
            buttonGuardarCambios.Click += delegate { 
                GuardarEvento?.Invoke(this, EventArgs.Empty);
                if (IsSuccesful)
                {
                    tabControl1.TabPages.Remove(tabPageCrud);
                    tabControl1.TabPages.Add(tabPageLectura);
                }
                MessageBox.Show(Message);
            };
            btnCancelar.Click += delegate { 
                CancelarEvento?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCrud);
                tabControl1.TabPages.Add(tabPageLectura);
            };
            buttonEliminar.Click += delegate { 
                var result = MessageBox.Show("Seguro que quieres eliminar este producto?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EliminarProductoEvento?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ProductoStock { get; set; }
        public string ProductoPrecio { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSuccesful { get; set; }
        public string Message { get; set; }

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
