using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace pruebaPracticaCoperex.Model
{
    internal class InventarioModel
    {
        private int _id;
        private int _productoId;
        private DateTime _fechaHora;
        private string _movimiento;
        private int _cantidad;

        [DisplayName("Id Inventario")]
        public int Id { 
            get => _id; 
            set => _id = value; 
        }

        [DisplayName("Id del Producto")]
        public int ProductoId {
            get => _productoId;
            set => _productoId = value; 
        }

        [DisplayName("Fecha y Hora")]
        [Required(ErrorMessage = "La fecha y hora es obligatoria")]
        public DateTime FechaHora {
            get => _fechaHora;
            set => _fechaHora = value; 
        }

        [DisplayName("Tipo Movimiento")]
        [Required(ErrorMessage = "El tipo de movimiento es obligatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El nombre del producto debe entrada o salida")]
        public string Movimiento {
            get => _movimiento; 
            set => _movimiento = value; 
        }

        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "La cantidad de producto es obligatoria.")]
        [Range(1, 999999, ErrorMessage = "La cantidad debe tener de 1 a 6 cifras.")]
        public int Cantidad { 
            get => _cantidad; 
            set => _cantidad = value; 
        }
    }
}
