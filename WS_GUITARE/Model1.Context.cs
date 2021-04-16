﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_GUITARE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class C_BASE : DbContext
    {
        public C_BASE()
            : base("name=C_BASE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Bois> Les_Bois { get; set; }
        public virtual DbSet<C_Client> Les_Clients { get; set; }
        public virtual DbSet<C_EtatCommande> Les_EtatCommande { get; set; }
        public virtual DbSet<C_Guitare> Les_Guitares { get; set; }
        public virtual DbSet<C_Micro> Les_Micros { get; set; }
        public virtual DbSet<C_Vibrato> Les_vibrato { get; set; }
    
        public virtual int Add_Guitare(Nullable<int> micro_neck, Nullable<int> micro_Bridge, Nullable<int> microCentrale, Nullable<int> bois_Manche, Nullable<int> bois_Touche, Nullable<int> bois_Corps, Nullable<int> id_Client, Nullable<int> vibrato)
        {
            var micro_neckParameter = micro_neck.HasValue ?
                new ObjectParameter("Micro_neck", micro_neck) :
                new ObjectParameter("Micro_neck", typeof(int));
    
            var micro_BridgeParameter = micro_Bridge.HasValue ?
                new ObjectParameter("Micro_Bridge", micro_Bridge) :
                new ObjectParameter("Micro_Bridge", typeof(int));
    
            var microCentraleParameter = microCentrale.HasValue ?
                new ObjectParameter("MicroCentrale", microCentrale) :
                new ObjectParameter("MicroCentrale", typeof(int));
    
            var bois_MancheParameter = bois_Manche.HasValue ?
                new ObjectParameter("Bois_Manche", bois_Manche) :
                new ObjectParameter("Bois_Manche", typeof(int));
    
            var bois_ToucheParameter = bois_Touche.HasValue ?
                new ObjectParameter("Bois_Touche", bois_Touche) :
                new ObjectParameter("Bois_Touche", typeof(int));
    
            var bois_CorpsParameter = bois_Corps.HasValue ?
                new ObjectParameter("Bois_Corps", bois_Corps) :
                new ObjectParameter("Bois_Corps", typeof(int));
    
            var id_ClientParameter = id_Client.HasValue ?
                new ObjectParameter("Id_Client", id_Client) :
                new ObjectParameter("Id_Client", typeof(int));
    
            var vibratoParameter = vibrato.HasValue ?
                new ObjectParameter("Vibrato", vibrato) :
                new ObjectParameter("Vibrato", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Guitare", micro_neckParameter, micro_BridgeParameter, microCentraleParameter, bois_MancheParameter, bois_ToucheParameter, bois_CorpsParameter, id_ClientParameter, vibratoParameter);
        }
    
        public virtual ObjectResult<get_bois_by_id_Result> get_bois_by_id(Nullable<int> id_bois)
        {
            var id_boisParameter = id_bois.HasValue ?
                new ObjectParameter("id_bois", id_bois) :
                new ObjectParameter("id_bois", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_bois_by_id_Result>("get_bois_by_id", id_boisParameter);
        }
    
        public virtual ObjectResult<Get_Guitare_Result> Get_Guitare()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Guitare_Result>("Get_Guitare");
        }
    
        public virtual ObjectResult<get_micro_by_id_Result> get_micro_by_id(Nullable<int> id_micro)
        {
            var id_microParameter = id_micro.HasValue ?
                new ObjectParameter("id_micro", id_micro) :
                new ObjectParameter("id_micro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_micro_by_id_Result>("get_micro_by_id", id_microParameter);
        }
    
        public virtual int Add_Client(string nom, string adresse, string telephone)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("Telephone", telephone) :
                new ObjectParameter("Telephone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Client", nomParameter, adresseParameter, telephoneParameter);
        }
    
        public virtual ObjectResult<C_EtatCommande> Get_Etat_Commande()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<C_EtatCommande>("Get_Etat_Commande");
        }
    
        public virtual ObjectResult<C_EtatCommande> Get_Etat_Commande(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<C_EtatCommande>("Get_Etat_Commande", mergeOption);
        }
    
        public virtual ObjectResult<Nullable<int>> Get_id_client_by_name(string nom)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("Nom", nom) :
                new ObjectParameter("Nom", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Get_id_client_by_name", nomParameter);
        }
    
        public virtual ObjectResult<Get_Micro_Result> Get_Micro()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Micro_Result>("Get_Micro");
        }
    
        public virtual ObjectResult<Get_Vibrato_Result> Get_Vibrato()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Vibrato_Result>("Get_Vibrato");
        }
    
        public virtual ObjectResult<Nullable<int>> Get_id_micro_by_Name(string nomMicro)
        {
            var nomMicroParameter = nomMicro != null ?
                new ObjectParameter("NomMicro", nomMicro) :
                new ObjectParameter("NomMicro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Get_id_micro_by_Name", nomMicroParameter);
        }
    
        public virtual ObjectResult<Get_Bois_Result> Get_Bois()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Bois_Result>("Get_Bois");
        }
    
        public virtual ObjectResult<Nullable<int>> Get_id_Bois_by_Name(string nomBois)
        {
            var nomBoisParameter = nomBois != null ?
                new ObjectParameter("NomBois", nomBois) :
                new ObjectParameter("NomBois", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Get_id_Bois_by_Name", nomBoisParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Get_id_Vibrato_by_Name(string vibrato)
        {
            var vibratoParameter = vibrato != null ?
                new ObjectParameter("Vibrato", vibrato) :
                new ObjectParameter("Vibrato", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Get_id_Vibrato_by_Name", vibratoParameter);
        }
    
        public virtual ObjectResult<GET_GUITARE_BY_ID_CLIENT_Result> GET_GUITARE_BY_ID_CLIENT(Nullable<int> idClient)
        {
            var idClientParameter = idClient.HasValue ?
                new ObjectParameter("idClient", idClient) :
                new ObjectParameter("idClient", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_GUITARE_BY_ID_CLIENT_Result>("GET_GUITARE_BY_ID_CLIENT", idClientParameter);
        }
    }
}
