using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using pruebaPracticaCoperex.Model;

using OfficeOpenXml;
using System.IO;

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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Producto VALUES (@Nombre, @Descripcion, @Stock, @Precio);";
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = productoModel.Nombre;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = productoModel.Descripcion;
                command.Parameters.Add("@Stock", SqlDbType.Int).Value = productoModel.Stock;
                command.Parameters.Add("@Precio", SqlDbType.Float).Value = productoModel.Precio;
                command.ExecuteNonQuery();
            }
        }

        public void Editar(ProductoModel productoModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Producto SET Nombre = @Nombre, Descripcion = @Descripcion, Stock = @Stock, Precio = @Precio WHERE Id=@Id";
                command.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = productoModel.Nombre;
                command.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = productoModel.Descripcion;
                command.Parameters.Add("@Stock", SqlDbType.Int).Value = productoModel.Stock;
                command.Parameters.Add("@Precio", SqlDbType.Float).Value = productoModel.Precio;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = productoModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Producto where Id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
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

        public void GenerarKardex()
        {
            var productoList = new List<ProductoModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT \r\n    CONCAT(FORMAT(i.FechaHora, 'dd-MM-yy'), ' ', CONVERT(varchar(8), i.FechaHora, 108)) AS FechaHora,\r\n    p.Nombre,\r\n    p.Descripcion,\r\n\tCASE WHEN i.Movimiento = 'Entrada' THEN p.Stock - i.Cantidad ELSE p.Stock + i.Cantidad END AS [Inv. Inicial],\r\n\tp.Precio AS [Costo Unitario],\r\n\tCASE WHEN i.Movimiento = 'Entrada' THEN i.Cantidad ELSE 0 END AS Entrada,\r\n    CASE WHEN i.Movimiento = 'Salida' THEN i.Cantidad ELSE 0 END AS Salida,\r\n\tp.Stock as [Inv. Final]\r\nFROM \r\n    Inventario i\r\n    INNER JOIN Producto p ON i.ProductoId = p.Id;";
                SqlDataReader reader = command.ExecuteReader();

                // Crear un nuevo archivo de Excel
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Crear una nueva hoja de Excel
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Datos");

                    // Escribir los encabezados de columna
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = reader.GetName(i);
                    }

                    // Escribir los datos
                    int row = 2;
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            worksheet.Cells[row, i + 1].Value = reader[i];
                        }
                        row++;
                    }

                    // Guardar el archivo de Excel
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Kardex.xlsx");
                    excelPackage.SaveAs(new System.IO.FileInfo(filePath));
                }
            }
        }



    }
}
