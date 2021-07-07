﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetCabinetDentaire
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class cabinet_dentaireEntities : DbContext
    {
        public cabinet_dentaireEntities()
            : base("name=cabinet_dentaireEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dent> dent { get; set; }
        public virtual DbSet<diagnostique> diagnostique { get; set; }
        public virtual DbSet<employe> employe { get; set; }
        public virtual DbSet<etat_paitent> etat_paitent { get; set; }
        public virtual DbSet<liste_attente> liste_attente { get; set; }
        public virtual DbSet<login_emp> login_emp { get; set; }
        public virtual DbSet<medicament_details> medicament_details { get; set; }
        public virtual DbSet<message_emp> message_emp { get; set; }
        public virtual DbSet<paitent> paitent { get; set; }
        public virtual DbSet<payement> payement { get; set; }
        public virtual DbSet<rendez_vous> rendez_vous { get; set; }
        public virtual DbSet<scanner> scanner { get; set; }
        public virtual DbSet<service_employe> service_employe { get; set; }
        public virtual DbSet<stock> stock { get; set; }
        public virtual DbSet<traiter> traiter { get; set; }
        public virtual DbSet<tranche> tranche { get; set; }
        public virtual DbSet<tuteur> tuteur { get; set; }
    
        public virtual ObjectResult<AfficherPatient_Result> AfficherPatient(Nullable<int> numPat, ObjectParameter rt)
        {
            var numPatParameter = numPat.HasValue ?
                new ObjectParameter("NumPat", numPat) :
                new ObjectParameter("NumPat", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AfficherPatient_Result>("AfficherPatient", numPatParameter, rt);
        }
    }
}
