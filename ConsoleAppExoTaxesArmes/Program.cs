namespace ConsoleAppExoTaxesArmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal prixArme;
            const decimal forgeCapitale = 0.20m;
            const decimal ateliersNains = 0.10m;
            const decimal contrebandiers = 0.055m;
            const decimal terresSacrees = 0.021m;
            Console.Write("Entrez le prix de l'arme : ");
            prixArme = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Quel est la zone de fabrication de l'arme ? (1: Forge Capitale, 2: Ateliers Nains, 3: Contrebandiers, 4: Terres Sacrées)");
            int zone = Convert.ToInt32(Console.ReadLine());
            decimal prixFinal;
            switch (zone)
            {
                case 1:
                    prixFinal = Math.Round(prixArme * (1 + forgeCapitale), 2);
                    break;
                case 2:
                    prixFinal = Math.Round(prixArme * (1 + ateliersNains), 2);
                    break;
                case 3:
                    prixFinal = Math.Round(prixArme * (1 + contrebandiers), 2);
                    break;
                case 4:
                    prixFinal = Math.Round(prixArme * (1 + terresSacrees), 2);
                    break;
                default:
                    Console.WriteLine("Zone de fabrication non reconnue.");
                    return;
            }
            Console.WriteLine("Le prix final de l'arme est : " + prixFinal + " pièces d'or");

        }
    }
}
