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
    
    public partial class traiter
    {
        public int ID_Tra { get; set; }
        public Nullable<int> MatTrEmp { get; set; }
        public Nullable<int> IDTrSer { get; set; }
        public Nullable<int> NumTrPat { get; set; }
        public Nullable<int> IDTrDiag { get; set; }
    
        public virtual diagnostique diagnostique { get; set; }
        public virtual employe employe { get; set; }
        public virtual paitent paitent { get; set; }
        public virtual service_employe service_employe { get; set; }
    }
}
