using System;
using System.Collections.Generic;

namespace Laboratorio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tarjeta tarjeta1 = new TarjetaAdulto(1000, 1);
            Tarjeta tarjeta2 = new TarjetaEstudiante(1000, 2);
            Tarjeta tarjeta3 = new TarjetaPreferencial(1000, 3);
            Tarjeta tarjeta4 = new TarjetaAdulto(1000, 4);
            Tarjeta tarjeta5 = new TarjetaEstudiante(1000, 5);

            List<Tarjeta> tarjetas = new List<Tarjeta>();
            tarjetas.Add(tarjeta1);
            tarjetas.Add(tarjeta2);
            tarjetas.Add(tarjeta3);
            tarjetas.Add(tarjeta4);
            tarjetas.Add(tarjeta5);

            Console.WriteLine("== Bienvenido a Simulador Torniquete ==");

            int hora = 6;
            int minutos = 0;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine($"Hora actual: {hora} con {minutos} minutos");
                Console.WriteLine("");
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("[1] Configurar Hora");
                Console.WriteLine("[2] Cobrar");
                Console.WriteLine("[3] Mostrar Saldo");
                Console.WriteLine("[4] Cerrar Programa");
                Console.WriteLine("");
                string opcion = Console.ReadLine();

                if (opcion == "1") {

                    Console.WriteLine("Ingresa la hora");
                    hora = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa los minutos");
                    minutos = int.Parse(Console.ReadLine());

                } else if (opcion == "2") {

                    Console.WriteLine("Ingresa el ID de la tarjeta");
                    int id = int.Parse(Console.ReadLine());
                    int indiceTarjeta = -1;

                    for (var i = 0; i < tarjetas.Count; i++) 
                    {
                        if (tarjetas[i].GetId() == id)
                        {
                            indiceTarjeta = i;
                            break;
                        }
                    }

                    if (indiceTarjeta >= 0)
                    {
                        Tarjeta tarjeta = tarjetas[indiceTarjeta];
                        bool pagoExitoso = tarjeta.Pagar(hora, minutos);
                        if (pagoExitoso)
                        {
                            Console.WriteLine($"El pago fue exitoso. Tu nuevo saldo es {tarjeta.GetSaldo()}");
                        } else {
                            Console.WriteLine("No tienes saldo sufiente");
                        }
                    } else {
                        Console.WriteLine("Esa tarjeta no existe");
                    }
                } else if (opcion == "3") {
                    Console.WriteLine("Los saldos de la tarjeta son:");
                    foreach(Tarjeta tarjeta in tarjetas) {
                        Console.WriteLine($"  Tarjeta #{tarjeta.GetId()}: ${tarjeta.GetSaldo()}");
                    }
                } else {
                    break;
                }
            }
        }
    }
}
