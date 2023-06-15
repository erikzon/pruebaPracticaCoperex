using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaPracticaCoperex.Model
{
    internal interface IProductoModel
    {
        void Crear(ProductoModel productoModel);
        void Editar(ProductoModel productoModel);
        void Eliminar(int id);

        IEnumerable<ProductoModel> GetAll();
        IEnumerable<ProductoModel> GetByValue();
    }
}
