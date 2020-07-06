
namespace Veterinaria
{
    class Veterinatria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string telefono { get; set; }
        public Mascota Mascotas { get; set; }
        public string veterinariaMascota() {
            return $"la veterinaria:{Nombre} esta atendiento a:{Mascotas.Nombre}\n";
        }
       
    }
}
