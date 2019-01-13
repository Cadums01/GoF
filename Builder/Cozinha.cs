namespace Builder
{
    public class Cozinha
    {
        public Sanduiche FazSanduiche(SanduicheBuilder builder)
        {
            builder.AbrePao();
            builder.InsereIngredientes();
            builder.FechaPao();
            
            return builder.GetSanduiche();
        }
    }
}