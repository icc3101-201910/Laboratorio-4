using System;

namespace Laboratorio4
{
    public class TarjetaPreferencial : Tarjeta
    {
        public TarjetaPreferencial(int saldoInicial, int id) : base(saldoInicial, id)
        {

        }

        protected override int GetTarifa(int hora, int minutos)
        {
            bool horarioPuntaAM = (hora == 7 || hora == 8) && (minutos <= 59);
            bool horarioPuntaPM = (hora == 18 || hora == 19) && (minutos <= 59);

            if (horarioPuntaAM || horarioPuntaPM)
            {
                return 800;
            }

            return 230;
        }
    }
}
