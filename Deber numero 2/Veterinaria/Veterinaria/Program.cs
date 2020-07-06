using System;

namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var veterinaria = new Veterinatria
            {
                Id = new Random().Next(),
                Nombre = "Pets & People",
                Direccion = "Fulgencia Araujo y Pasaje 4 de Junio",
                telefono = "3202523/0978614735"
            };

            var cliente = new Cliente
            {
                Id = new Random().Next(),
                Cedula = "172516407-1",
                Nombres = "Erika Graciela",
                Apellidos = "Guamanzara Orozco",
                Telefono = "0987472354"
            };

            var mascota = new Mascota
            {
                Id = new Random().Next(),
                Nombre = "Pakun",
                Tipo = "Perro",
                Raza = "Pastor Aleman",
                Color = "Negro y Cafe",
                Edad = 7
            };

            var medicamentos = new Medicamentos
            {
                Id = new Random().Next(),
                Nombre = "suero",
                Material = "plastico"

            };

            cliente.Mascota = mascota;
            mascota.Medicamento = medicamentos;
            veterinaria.Mascotas = mascota;
            Console.Write(cliente.datosCliente());
            Console.Write(cliente.mostrarMascota());
            Console.Write(mascota.medicamentoMascota());
            Console.Write(veterinaria.veterinariaMascota());
            Console.ReadKey();
            


        }
        }
    }

