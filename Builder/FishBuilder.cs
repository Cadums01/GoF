using System;

namespace Builder
{
    public class FishBuilder:SanduicheBuilder
    {
        private FishBurguer sanduiche = new FishBurguer();

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
            Console.WriteLine("FishBurger está pronto !");

            return sanduiche;
        }
    }
}