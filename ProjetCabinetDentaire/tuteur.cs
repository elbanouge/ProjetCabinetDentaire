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
    
    public partial class tuteur
    {
        public int Num_Tuteur { get; set; }
        public string Nom_Tut { get; set; }
        public string Prenom_Tut { get; set; }
        public string Sexe_Tut { get; set; }
        public string Lien_Tut { get; set; }
        public string CIN_Tut { get; set; }
        public Nullable<int> NumPatTut { get; set; }
    
        public virtual paitent paitent { get; set; }
    }
}