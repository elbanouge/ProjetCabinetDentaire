//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class service_employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service_employe()
        {
            this.traiter = new HashSet<traiter>();
        }
    
        public int ID_Ser { get; set; }
        public string Nom_Ser { get; set; }
        public string Description_Ser { get; set; }
        public Nullable<decimal> Prix_Origine { get; set; }
        public Nullable<int> MatServ { get; set; }
    
        public virtual employe employe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<traiter> traiter { get; set; }
    }
}