using System;

namespace FactoryMethod
{
    public class EmpresaOnibusInterEstadual:Empresa
    {
        public override Passagem EmitePassagem(string oritem, string destino, DateTime dataHoraPartida)
        {
            return  new PassagemOnibusInterEstadual(oritem, destino, dataHoraPartida);
        }
    }
}