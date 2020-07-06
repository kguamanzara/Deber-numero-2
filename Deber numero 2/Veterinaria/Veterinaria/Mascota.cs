
using System.Reflection.Metadata.Ecma335;

namespace Veterinaria
{
    class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public Cliente Propietario { get; set; }
        public Medicamentos Medicamento { get; set; }
        public string medicamentoMascota() {
            return $"la mascota:{Nombre}, \n va a recibir {Medicamento.Nombre}, \n Tipo de material:{Medicamento.Material}\n";
        }

    }
}
