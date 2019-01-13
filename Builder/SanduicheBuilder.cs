using System;

namespace Builder
{
    public abstract class SanduicheBuilder
    {
        public abstract void AbrePao();
        public abstract void InsereIngredientes();
        public abstract void FechaPao();
        public abstract Sanduiche GetSanduiche();
    }
}