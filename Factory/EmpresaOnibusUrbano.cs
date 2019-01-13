using System;

namespace FactoryMethod
{
    public class EmpresaOnibusUrbano : Empresa
    {
        public override Passagem EmitePassagem(string oritem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(oritem, destino, dataHoraPartida);
        }
    }
}