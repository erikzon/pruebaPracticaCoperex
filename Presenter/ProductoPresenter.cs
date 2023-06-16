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
            this.view.AgregarProductoEvento += AgregarNuevoProducto;
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
            LimpiarCuadrosTexto();
        }

        private void GuardarEvento(object sender, EventArgs e)
        {
            var model = new ProductoModel();
            model.Id = Convert.ToInt32(view.ProductoID);
            model.Nombre = view.ProductoNombre.ToString();
            model.Descripcion = view.ProductoDescripcion.ToString();
            model.Precio = Convert.ToDouble(view.ProductoPrecio);
            model.Stock = Convert.ToInt32(view.ProductoStock);

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Editar(model);
                    view.Message = "Producto editado correctamente.";
                } else
                {
                    repository.Crear(model);
                    view.Message = "Producto creado correctamente.";
                }
                view.IsSuccesful = true;
                CargarProductos();
                LimpiarCuadrosTexto();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void LimpiarCuadrosTexto()
        {
            view.ProductoNombre = "";
            view.ProductoID = "0";
            view.ProductoDescripcion = "";
            view.ProductoStock = "";
            view.ProductoPrecio = "";
        }

        private void AgregarNuevoProducto(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            try
            {
                var producto = (ProductoModel)productoBindingSource.Current;
                repository.Eliminar(producto.Id);
                view.IsSuccesful = true;
                view.Message = "Producto eliminado correctamente";
                CargarProductos();
            }
            catch (Exception ex)
            {
                view.IsSuccesful= false;
                view.Message = ex.Message;
            }
        }

        private void EditarProducto(object sender, EventArgs e)
        {
            var producto = (ProductoModel)productoBindingSource.Current;
            view.ProductoNombre = producto.Nombre;
            view.ProductoID = producto.Id.ToString();
            view.ProductoDescripcion = producto.Descripcion;
            view.ProductoStock= producto.Stock.ToString();
            view.ProductoPrecio = producto.Precio.ToString();
            view.IsEdit = true;
        }

        private void AgregarProducto(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
