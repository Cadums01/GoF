using System;

namespace FactoryMethod
{
    public abstract class Empresa
    {
        public abstract Passagem EmitePassagem(string oritem, string destino, DateTime dataHoraPartida);
    }
}