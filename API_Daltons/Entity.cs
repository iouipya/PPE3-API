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
    
    public partial class Entity
    {
        public Entity()
        {
            this.Client = new HashSet<Client>();
            this.Societe = new HashSet<Societe>();
        }
    
        public int id_entity { get; set; }
        public string libelle { get; set; }
    
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Societe> Societe { get; set; }
    }
}