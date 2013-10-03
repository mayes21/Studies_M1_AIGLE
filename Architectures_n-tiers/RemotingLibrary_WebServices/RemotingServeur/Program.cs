using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemotingServeur
{
    public partial class RemoteOperation : MarshalByRefObject
    {
        Dictionary<string, string> listAdmin = new Dictionary<string, string>();
        List<Livre> listLivre;

        /* Constructeur */
        public RemoteOperation()
        {

            this.AddAdmin();
            listLivre = new List<Livre>();
        }

        // Indique que l'objet aura une durée de vie illimitée
        public override object InitializeLifetimeService()
        {
            return null;
        }

        /* Ajout des administrateurs */
        public void AddAdmin()
        {
            listAdmin.Add("Admin1", "admin1234");
            listAdmin.Add("Admin2", "test1234");
        }

    }
}
