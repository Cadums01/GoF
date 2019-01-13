using System;

namespace Builder
{
    public class HamburguerBuilder : SanduicheBuilder
    {
        private Sanduiche sanduiche = new Hamburguer();

        public override void AbrePao()
        {
            Console.WriteLine("Abre pão.");
        }

        public override void InsereIngredientes()
        {
            Console.WriteLine("Insere ingredientes.");
        }

        public override void FechaPao()
        {
            Console.WriteLine("Fecha pão.");
        }

        public override Sanduiche GetSanduiche()
        {
            Console.WriteLine("Hamburguer está pronto !");

            return sanduiche;
        }
    }
}