using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Share;
using System.ServiceModel;

namespace ServiceRecettes
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class ServiceImpl : IContract 
    {

        List<Ingredient> listIng1 = new List<Ingredient>();
        List<Ingredient> listIng2 = new List<Ingredient>();
        List<Ingredient> listIng3 = new List<Ingredient>();

        Ingredient pdt = new Ingredient("pomme de terre");
        Ingredient beurre = new Ingredient("beurre");
        Ingredient lait = new Ingredient("lait");

        Ingredient couscous = new Ingredient("couscous");
        Ingredient sauce = new Ingredient("sauce");

        Ingredient haricots = new Ingredient("haricots");
        Ingredient tomate = new Ingredient("tomate");
        Ingredient oignon = new Ingredient("oignon");

        List<Recette> listRec;
        
        
        /* Base recettes */
        public List<Recette> BaseRecettes()
        {
            listIng1.Add(couscous); /* listIng1 = ingr1.2 + ingr2.1 + ingr3.1 */
            listIng1.Add(beurre);
            listIng1.Add(lait);

            listIng2.Add(haricots); /* listIng2 = ingr1.3 + ingr2.2 */
            listIng2.Add(sauce);

            listIng3.Add(haricots); /* listIng3 = ingr1.3 + ingr2.3 + ingr3.3 */
            listIng3.Add(tomate);
            listIng3.Add(oignon);

            Recette puree = new Recette("purée", listIng1);
            Recette pate = new Recette("couscous", listIng2);
            Recette lentilles = new Recette("haricots", listIng3);

            listRec = new List<Recette>();

            listRec.Add(puree);
            listRec.Add(pate);
            listRec.Add(lentilles);

            int i = 1;
            foreach(Recette rec in listRec)
            {    
                Console.WriteLine("Recette ["+i+"] = "+rec.TitreRecette);
                i++;
            }

            return listRec;

        }


        List<Recette> SelectCourante = new List<Recette>();

        /* rechercher la liste des recettes dans la composition desquelles entre un ingredient de nom donne */
        public List<Recette> GetRecetteIng(Ingredient ingr)
        {
            foreach (Recette rec in listRec)
            {
                
                foreach (Ingredient ing in rec.ListIngr)
                {
                    if (ing.NomIngr.Equals(ingr.NomIngr))
                    {
                        SelectCourante.Add(rec);
                    }
                }
            }

            return SelectCourante;
        }


        /* memoriser le resultat de la derniere recherche comme la selection courante du client */
        public List<Recette> GetCurrent()
        {
            return SelectCourante;
        }

        /* supprimer une recette donnee de la selection courante */
        public List<Recette> RemoveRec(string titreRec)
        {
            foreach (Recette rec in SelectCourante)
            {
                if (titreRec.Equals(rec.TitreRecette))
                {
                    SelectCourante.Remove(rec);
                    Console.WriteLine("[OK] Item supprimé...");
                    return SelectCourante;
                }
            }
            Console.WriteLine("[ECHEC] Item non trouvé...");
            return SelectCourante;
        }


        /* Ajout d'une recette à la base de recettes */
        public List<Recette> AddRec(Recette rec)
        {

            foreach (Recette rece in listRec)
            {
                if ((rec.TitreRecette).Equals(rece.TitreRecette))
                {
                    Console.WriteLine("\n[ECHEC] Recette déjà en base...");
                    return listRec;
                }
            }
           
            listRec.Add(rec);
            Console.WriteLine("\n[OK] Recette ajouté...");
            return listRec;
        }

        /*
         * ====================== TEST ==================== 
         * 
         * 
        int m_Counter = 0;
        public int MyMethod()
        {
            m_Counter++;
            return m_Counter;
        }

        public string SayHello()
        {
            return "Hello World !";
        }*/
        
    }
}
