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
    
    public partial class rendez_vous
    {
        public int ID_RDV { get; set; }
        public Nullable<System.DateTime> Date_RDV { get; set; }
        public Nullable<System.TimeSpan> Horaire_RDV { get; set; }
        public string Description_RDV { get; set; }
        public Nullable<int> NumPtRdv { get; set; }
        public Nullable<int> MatRDV { get; set; }
    
        public virtual employe employe { get; set; }
        public virtual paitent paitent { get; set; }
    }
}
