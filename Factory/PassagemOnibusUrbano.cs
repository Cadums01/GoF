using System;

namespace FactoryMethod
{
    public class PassagemOnibusUrbano:Passagem
    {
        public PassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida) 
            : base(origem, destino, dataHoraPartida)
        {
        }
        
        public override string ToString()
        {
            return
                $"Passagem de ônibus Inter Urbano: {Origem} Para: {Destino} Data/hora {DataHoraPartida.ToString("dd/MM/yyyy")}";
        }
    }
}