using System;

namespace AbstractFactory
{
    public class ConcretePassagemOnibusInterEstadual : PassagemOnibusInterEstadual
    {
        public ConcretePassagemOnibusInterEstadual(string origem, string destino, DateTime dataHoraPartida)
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override string ToString()
        {
            return
                $"Passagem de ônibus Inter Estadual: {Origem} Para: {Destino} Data/hora {DataHoraPartida.ToString("dd/MM/yyyy")}";
        }
    }
}