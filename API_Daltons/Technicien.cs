//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Daltons
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technicien
    {
        public Technicien()
        {
            this.Compte_rendu = new HashSet<Compte_rendu>();
            this.Intervention = new HashSet<Intervention>();
        }
    
        public int id_technicien { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int id_materiel { get; set; }
        public string tel { get; set; }
    
        public virtual ICollection<Compte_rendu> Compte_rendu { get; set; }
        public virtual ICollection<Intervention> Intervention { get; set; }
        public virtual Materiel Materiel { get; set; }
    }
}
