/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 24/07/2023
 * Time: 16:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projet__5

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Gestion de vente de produit ===");

            // Saisie des informations du produit
            Console.Write("Code du produit : ");
            string codeProduit = Console.ReadLine();

            Console.Write("Nom du produit : ");
            string nomProduit = Console.ReadLine();

            Console.Write("Catégorie du produit : ");
            string categorieProduit = Console.ReadLine();

            Console.Write("Prix unitaire du produit : ");
            double prixUnitaire = double.Parse(Console.ReadLine());

            Console.Write("Quantité vendue : ");
            int quantiteVendue = int.Parse(Console.ReadLine());

            Console.Write("Date de vente : ");
            string dateVente = Console.ReadLine();

            // Calcul du montant sans remise
            double montantSansRemise = prixUnitaire * quantiteVendue;

            // Calcul du taux de remise en fonction de la quantité vendue
            double tauxRemise = 0.0;
            if (quantiteVendue < 10)
                tauxRemise = 0.10;
            else if (quantiteVendue >= 10 && quantiteVendue <= 30)
                tauxRemise = 0.20;
            else if (quantiteVendue >= 31 && quantiteVendue <= 50)
                tauxRemise = 0.40;
            else if (quantiteVendue >= 51)
                tauxRemise = 0.60;

            // Calcul du montant avec remise
            double montantAvecRemise = montantSansRemise * (1 - tauxRemise);

            // Saisie du montant versé pour le règlement
            Console.Write("Montant versé : ");
            double montantVerse = double.Parse(Console.ReadLine());

            // Calcul de la monnaie à rendre
            double monnaieARendre = montantVerse - montantAvecRemise;

            // Affichage des informations du produit et des calculs
            Console.WriteLine("\n=== Informations du produit ===");
            Console.WriteLine("Code : " + codeProduit);
            Console.WriteLine("Nom : " + nomProduit);
            Console.WriteLine("Catégorie : " + categorieProduit);
            Console.WriteLine("Prix unitaire : " + prixUnitaire);
            Console.WriteLine("Quantité vendue : " + quantiteVendue);
            Console.WriteLine("Date de vente : " + dateVente);

            Console.WriteLine("\n=== Calculs ===");
            Console.WriteLine("Montant sans remise : " + montantSansRemise);
            Console.WriteLine("Taux de remise : " + (tauxRemise * 100) + "%");
            Console.WriteLine("Montant avec remise : " + montantAvecRemise);
            Console.WriteLine("Monnaie à rendre : " + monnaieARendre);
        }
    }
}
