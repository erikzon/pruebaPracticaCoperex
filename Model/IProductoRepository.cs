using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaPracticaCoperex.Model
{
    public interface IProductoRepository 
    {
        void Crear(ProductoModel productoModel);
        void Editar(ProductoModel productoModel);
        void Eliminar(int id);

        void GenerarKardex();

        IEnumerable<ProductoModel> ObtenerTodos();
    }
}
