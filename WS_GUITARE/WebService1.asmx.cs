using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_GUITARE
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        C_BASE Base = new C_BASE();

        

            [WebMethod]
        public string Add_Guitare(int? Micro_neck ,int? Micro_Bridge, int? Micro_Central,
        int? Bois_Manche, int? Bois_Touche, int? Bois_Corps, int? Id_Client, int? Vibrato)
        {
                Base.Add_Guitare(Micro_neck, Micro_Bridge, Micro_Central, Bois_Manche, Bois_Touche, Bois_Corps, Id_Client, Vibrato); 
            return "Commande ajoutée";
        } 
        
        [WebMethod]

         public List<Get_Guitare_Result> Get_Guitare()
         {
            return Base.Get_Guitare().ToList();
         }

        [WebMethod]

        public List<get_bois_by_id_Result> Get_bois_by_id(int id_bois)
        {
            return Base.get_bois_by_id(id_bois).ToList();
        }

        [WebMethod]

        public List<get_micro_by_id_Result> Get_micro_by_id(int id_micro)
        {
            return Base.get_micro_by_id(id_micro).ToList();
        }

        [WebMethod]

        public void add_client(string Nom, string Adresse, string telephone)
        {
            Base.Add_Client(Nom,Adresse,telephone) ;
        }

        [WebMethod]
        public List<Get_Micro_Result> Get_Micro()
        {
            return Base.Get_Micro().ToList();
        }

        [WebMethod]
        public List<Get_Vibrato_Result> Get_Vibrato()
        {
            return Base.Get_Vibrato().ToList();
        }

        [WebMethod]
        public List<Get_Bois_Result> Get_Bois()
        {
            return Base.Get_Bois().ToList();
        }

        [WebMethod]
        public List<C_EtatCommande> Get_EtatCommande()
        {
            return Base.Get_Etat_Commande().ToList();
        }

        [WebMethod]
        public List<int?> Get_id_client_by_name(string nom)
        { 
            return Base.Get_id_client_by_name(nom).ToList();
        }

        [WebMethod]
        public List<int?> Get_id_Micro_By_Name(string NomMicro)
        {
            return Base.Get_id_micro_by_Name(NomMicro).ToList();
        }

        [WebMethod]
        public List<int?> Get_Id_Bois_By_Name(string nomBois)
        {
            return Base.Get_id_Bois_by_Name(nomBois).ToList();
        }

        [WebMethod]
        public List<int?> Get_id_Vibrato_by_Name(string nomVibrato)
        {
            return Base.Get_id_Vibrato_by_Name(nomVibrato).ToList();
        }

        [WebMethod]
        public List<GET_GUITARE_BY_ID_CLIENT_Result> Get_Guitare_By_IdClient(int idClient)
        {
            return Base.GET_GUITARE_BY_ID_CLIENT(idClient).ToList();
        }

        [WebMethod]
        public String get_time()
        {
            return DateTime.Now.ToString();
        }
    }
}
