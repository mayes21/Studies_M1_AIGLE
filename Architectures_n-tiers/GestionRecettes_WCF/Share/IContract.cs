using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Share
{
    
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IContract
    {

        [OperationContract]
        List<Recette> BaseRecettes();

        [OperationContract]
        List<Recette> GetRecetteIng(Ingredient ingr);

        [OperationContract]
        List<Recette> GetCurrent();

        [OperationContract]
        List<Recette> RemoveRec(string titreRec);

        [OperationContract]
        List<Recette> AddRec(Recette rec);

        /* 
         * 
         * ================= test ==================
         *   
        [OperationContract]
        string SayHello();
         
        [OperationContract]
        int MyMethod();
         */
    }

    [DataContract]
    public class Ingredient
    {
        string nomIngr;
        
        public Ingredient(string nomIng)
        {
            nomIngr = nomIng;
        }

        [DataMember]
        public string NomIngr
        {
            get { return nomIngr; }
            set { nomIngr = value; }
        }
    }


    [DataContract]
    public class Recette
    { 
        List<Ingredient> listIngr;

        string titreRecette;

        public Recette(string titreRec, List<Ingredient> listIn)
        {
            titreRecette = titreRec;
            listIngr = listIn;  
        }

        [DataMember]
        public string TitreRecette
        {
            get { return titreRecette; }
            set { titreRecette = value; }
        }

        [DataMember]
        public List<Ingredient> ListIngr
        {
            get { return listIngr; }
            set { listIngr = value; }
        }


    }

    
}
