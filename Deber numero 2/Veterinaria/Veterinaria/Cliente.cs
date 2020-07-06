

namespace Veterinaria
{
    class Cliente
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        private Mascota mascota;
        public Mascota Mascota
        {
            get { return mascota; }
            set
            {
                mascota = value;
                mascota.Propietario = this;
            }
        }
        public string datosCliente()
        {
            return $"cliente con el numero de cedula:{Cedula}\n Nombres y Apellidos:{Nombres} {Apellidos} \n Telefono:{Telefono}\n";
        }
        public string mostrarMascota() {
            return $"Su mascota tiene el nombre:{Mascota.Nombre}\n Tipo:{Mascota.Tipo}\n Raza:{Mascota.Raza}\n Color:{Mascota.Color}\n Edad:{Mascota.Edad}\n";
        }
    }
}
