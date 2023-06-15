using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pruebaPracticaCoperex.Model;
using pruebaPracticaCoperex.View;

namespace pruebaPracticaCoperex.Presenter
{
    public class ProductoPresenter
    {
        private IProductoView view;
        private IProductoRepository repository;
        private BindingSource productoBindingSource;
        private IEnumerable<ProductoModel> productoList;

        public ProductoPresenter(IProductoView view, IProductoRepository repository)
        {
            this.productoBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //eventos
            this.view.AgregarProductoEvento += AgregarProducto;
            this.view.EditarProductoEvento += EditarProducto;
            this.view.EliminarProductoEvento += EliminarProducto;
            this.view.AgregarProductoEvento += AgregarNuevoProducto;
            this.view.GuardarEvento += GuardarEvento;
            this.view.CancelarEvento += CancelarEvento;

            //binding source
            this.view.SetProductoListBindingSource(productoBindingSource);
            //cargar productos
            CargarProductos();
            this.view.Show();
            //this.view.Mostrar();
        }

        private void CargarProductos()
        {
            productoList = repository.ObtenerTodos();
            productoBindingSource.DataSource = productoList;
        }

        private void CancelarEvento(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarEvento(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarNuevoProducto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditarProducto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarProducto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
