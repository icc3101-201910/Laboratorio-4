using System;

namespace Laboratorio4
{
    public abstract class Tarjeta
    {
        int saldo;
        int id;

        public Tarjeta(int saldoInicial, int ID)
        {
            saldo = saldoInicial;
            id = ID;
        }

        public int GetSaldo()
        {
            return saldo;
        }

        public int GetId()
        {
            return id;
        }

        protected abstract int GetTarifa(int hora, int minutos);

        public bool Pagar(int hora, int minutos) 
        {
            int tarifaActual = GetTarifa(hora, minutos);
            int nuevoSaldo = saldo - tarifaActual;
            if (nuevoSaldo >= 0) 
            {
                saldo = nuevoSaldo;
                return true;
            }
            return false;
        }
    }
}
