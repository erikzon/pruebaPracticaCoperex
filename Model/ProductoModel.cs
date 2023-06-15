using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace pruebaPracticaCoperex.Model
{
    public class ProductoModel
    {
        private int _id;
        private string _nombre;
        private string _descripcion;
        private int _stock;
        private double _precio;

        [DisplayName("ID Producto")]
        public int Id { 
            get => _id; 
            set => _id = value; 
        }

        [DisplayName("Nombre Producto")]
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(50,MinimumLength =1, ErrorMessage = "El nombre del producto debe ser entre 2 y 50 caracteres.")]
        public string Nombre { 
            get => _nombre; 
            set => _nombre = value; 
        }

        [DisplayName("Descripcion Producto")]
        [Required(ErrorMessage = "La Descripcion del producto es obligatoria")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La descripcion del producto debe ser entre 5 y 100 caracteres.")]
        public string Descripcion { 
            get => _descripcion; 
            set => _descripcion = value; 
        }

        [DisplayName("Stock Producto")]
        [Required(ErrorMessage = "La cantidad de stock es obligatorio.")]
        [Range(1, 999999, ErrorMessage = "El stock del producto debe tener de 1 a 6 cifras.")]
        public int Stock { 
            get => _stock; 
            set => _stock = value; 
        }

        [DisplayName("Precio del Producto")]
        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        public double Precio { 
            get => _precio; 
            set => _precio = value;
        }
    }
}
