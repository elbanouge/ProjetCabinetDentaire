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
    
    public partial class medicament_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medicament_details()
        {
            this.diagnostique = new HashSet<diagnostique>();
        }
    
        public int ID_Med { get; set; }
        public string Nom_Med { get; set; }
        public int Quantite { get; set; }
        public string Description_Med { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diagnostique> diagnostique { get; set; }
    }
}
