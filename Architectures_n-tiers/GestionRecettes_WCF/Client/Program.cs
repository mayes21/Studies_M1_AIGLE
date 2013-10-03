using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Share;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IContract serviceProxy = new ChannelFactory<IContract>("configClient").CreateChannel();

            Console.WriteLine("\n----------------Recettes dans la base----------------\n");

            /* Appel à base recette */
            List<Recette> Recettes = serviceProxy.BaseRecettes();
            foreach (Recette r in Recettes)
            {
                Console.WriteLine(r.TitreRecette);
            }

            Console.WriteLine("\n----------------Recherche----------------\n");
            /* Chercher les recettes */

            Console.WriteLine("Saisir le nom de l'ingredient pour la selection courante : ");
            string ingr = Console.ReadLine();

            Ingredient ingredient = new Ingredient(ingr);
            
            List<Recette> listRecetteSelect = serviceProxy.GetRecetteIng(ingredient);

            int i = 1;
            foreach (Recette rec in listRecetteSelect)
            {
                Console.WriteLine("Recette ["+i+"] = "+rec.TitreRecette);
                i++;
            }


            Console.WriteLine("\n------------------Selection courante--------------------\n");
            /* Retourne la selection courante */
            List<Recette> listCourante = serviceProxy.GetCurrent();
            int j = 1;
            foreach (Recette rec in listCourante)
            {
                Console.WriteLine("Recette courante [" + j + "] = " + rec.TitreRecette);
                j++;
            }


            Console.WriteLine("\n----------Suppression et recuperation de la selection courante----------\n");

            Console.Write("Saisir le nom de la recette à supprimer : ");
            string nomRe = Console.ReadLine();

            List<Recette> lisSupp = serviceProxy.RemoveRec(nomRe);
            /* Retourne la selection courante après suppression */
            int k = 1;
            foreach (Recette rec in lisSupp)
            {
                Console.WriteLine("Nouvelle recette courante [" + k + "] = " + rec.TitreRecette);
                k++;
            }

            Console.WriteLine("\n----------Ajout d'une nouvelle recette dans la base de recettes----------\n");

            Console.WriteLine("Saisir le nombre d'ingredients pour la recette : ");
            string nbrIng = Console.ReadLine();

            int nbr = int.Parse(nbrIng);

            List<Ingredient> listIng = new List<Ingredient>();

            Ingredient[] arrayIng = new Ingredient[nbr];

            for (int h = 0; h < nbr; h++)
            {
                Console.Write("Ingredient "+(h+1)+": ");
                string titreIng = Console.ReadLine();

                arrayIng[h] = new Ingredient(titreIng);
                listIng.Add(arrayIng[h]);
            }

            foreach (Ingredient ing in listIng)
            {
                Console.WriteLine("Ingredient = "+ing.NomIngr);
            }

            Console.Write("Saisir le nom de la recette : ");
            string nomRec = Console.ReadLine();

            Recette rec4 = new Recette(nomRec, listIng);

            Console.WriteLine("\n");
            
            List<Recette> newListRec = serviceProxy.AddRec(rec4);

            /* Affichage de la nouvelle base de recettes */
            foreach(Recette rec in newListRec)
            {
                Console.WriteLine(rec.TitreRecette);
            }


            /*
             *  ====================== TEST =====================
             *  
             * 
            Console.WriteLine(serviceProxy.SayHello());
            Console.WriteLine(serviceProxy.MyMethod());
            Console.WriteLine(serviceProxy.MyMethod());
            Console.WriteLine(serviceProxy.MyMethod());
            Console.WriteLine(serviceProxy.MyMethod());
             */



            Console.ReadLine();
        }
    }
}
