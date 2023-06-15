using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaPracticaCoperex.View
{
    public interface IProductoView
    {
        string ProductoID { get; set; }
        string ProductoNombre { get; set; }
        string ProductoDescripcion { get; set; }
        string ProductoStock { get; set; }
        string ProductoPrecio { get; set; }

        string Buscar { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler BusquedaEvento;
        event EventHandler AgregarProductoEvento;
        event EventHandler EditarProductoEvento;
        event EventHandler EliminarProductoEvento;
        event EventHandler GuardarEvento;
        event EventHandler CancelarEvento;

        void SetProductoListBindingSource(BindingSource productoList);
        void Mostrar();

    }
}
