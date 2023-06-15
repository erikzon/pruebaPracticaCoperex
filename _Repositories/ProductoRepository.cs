using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using pruebaPracticaCoperex.Model;

namespace pruebaPracticaCoperex._Repositories
{
    public class ProductoRepository : BaseRepository, IProductoRepository
    {
        //Constructor
        public ProductoRepository(string connectionString) {
            this.connectionString = connectionString;
        }

        public void Crear(ProductoModel productoModel)
        {
            throw new NotImplementedException();
        }

        public void Editar(ProductoModel productoModel)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoModel> ObtenerTodos()
        {
            var productoList = new List<ProductoModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Producto order by Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productoModel = new ProductoModel();
                        productoModel.Id = (int)reader[0];
                        productoModel.Nombre = reader[1].ToString();
                        productoModel.Descripcion = reader[2].ToString();
                        productoModel.Stock = (int)reader[3];
                        productoModel.Precio = (double) reader[4];
                        productoList.Add(productoModel);
                    }
                }
            }
            return productoList;
        }



    }
}
