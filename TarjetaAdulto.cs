using System;
namespace Laboratorio4
{
    public class TarjetaAdulto : Tarjeta
    {
        public TarjetaAdulto(int saldoInicial, int id) : base(saldoInicial, id)
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

            bool horarioValleAM = hora == 6 && minutos <= 29;
            bool horarioValleTarde = hora >= 9 && hora <= 17;
            bool horarioValleNoche = hora == 20 && minutos <= 44;

            if (horarioValleAM || horarioValleTarde || horarioValleNoche)
            {
                return 720;
            }

            return 700;
        }
    }
}
