using System;

namespace AbstractFactory
{
    public abstract class EmpresaOnibus
    {
        public abstract PassagemOnibusUrbano EmitePassagemOnibusUrbano(string origem, string destino,
            DateTime dataHoraPartida);

        public abstract PassagemOnibusInterEstadual EmitePassagemOnibusInterEstadual(string origem, string destino,
            DateTime dataHoraPartida);
    }
}