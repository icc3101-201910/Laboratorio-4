using System;

namespace Laboratorio4
{
    public class TarjetaEstudiante : Tarjeta
    {
        public TarjetaEstudiante(int saldoInicial, int id) : base(saldoInicial, id)
        {

        }

        protected override int GetTarifa(int hora, int minutos)
        {
            return 230;
        }
    }
}
