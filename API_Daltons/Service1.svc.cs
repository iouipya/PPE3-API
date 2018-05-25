using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace API_Daltons
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
       #region Add

        public int AddCompte_Rendu(Compte_rendu compte_rendu)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.AddCompte_Rendu(compte_rendu.note, compte_rendu.id_technicien, compte_rendu.id_societe);
            }
            return 1;
        }

        public int AddIntervention(Intervention intervention)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.AddIntervention(intervention.id_motif, intervention.date_intervention, intervention.id_compte_rendu, intervention.id_etat, intervention.id_technicien, intervention.id_societe);
            }

            return 1;
        }

        //public void AddMateriel(Materiel materiel)
        //{
        //    using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
        //    {
        //        bdd.AddMateriel(materiel.num_serie, materiel.modele);
        //    }
        //}

        public int AddSociete(Societe societe)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.AddSociete(societe.nom_societe, societe.adresse_societe, societe.email_societe, societe.ville_societe, societe.cp_societe, societe.tel_societe);
            }
            return 1;
        }

        public int AddTechnicien(Technicien technicien)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.AddTechnicien(technicien.nom, technicien.prenom, technicien.id_materiel, technicien.tel);
            }
            return 1;
        }
        #endregion

        #region Delete 

        public void DeleteCompte_Rendu(Compte_rendu compte_rendu)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.DeleteCompte_Rendu(compte_rendu.id_compte_rendu);
            }
        }

        public void DeleteIntervention(Intervention intervention)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.DeleteIntervention(intervention.id_intervention);
            }
        }

        public void DeleteMateriel(Materiel materiel)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.DeleteMateriel(materiel.id_materiel);
            }
        }

        public void DeleteSociete(Societe societe)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.DeleteSociete(societe.id_societe);
            }
        }

        public void DeleteTechnicien(Technicien technicien)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.Configuration.ProxyCreationEnabled = false;
                bdd.DeleteTechnicien(technicien.id_technicien);
            }
        }
        #endregion

        #region Search
        public IList<Compte_rendu> SearchCompte_rendu()
        {
            IList<SearchCompte_Rendu_Result> maListeBDD;
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                maListeBDD = bdd.SearchCompte_Rendu().ToList();
            }

            // Translation vers une liste de matériel

            IList<Compte_rendu> ListeCompte_rendu = new List<Compte_rendu>();

            foreach (SearchCompte_Rendu_Result one in maListeBDD)
            {
                Compte_rendu temp = new Compte_rendu();
                temp.note = one.note;
                temp.id_technicien = one.id_technicien;
                temp.id_societe = one.id_societe;
                ListeCompte_rendu.Add(temp);
            }

            return ListeCompte_rendu;
        }

        public IList<Intervention> SearchIntervention()
        {
            IList<SearchIntervention_Result> maListeBDD;
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                maListeBDD = bdd.SearchIntervention().ToList();
            }

            // Translation vers une liste de matériel

            IList<Intervention> ListeIntervention = new List<Intervention>();

            foreach (SearchIntervention_Result one in maListeBDD)
            {
                Intervention temp = new Intervention();
                temp.id_intervention = one.id_intervention;
                temp.id_motif = one.id_motif;
                temp.date_intervention = one.date_intervention;
                temp.id_compte_rendu = one.id_compte_rendu;
                temp.id_etat = one.id_etat;
                temp.id_technicien = one.id_technicien;
                temp.id_societe = one.id_societe;
                ListeIntervention.Add(temp);
            }

            return ListeIntervention;
        }

        public IList<Materiel> SearchMateriel()
        {
            IList<SearchMateriel_Result> maListeBDD;
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                maListeBDD = bdd.SearchMateriel().ToList();
            }

            // Translation vers une liste de matériel

            IList<Materiel> ListeMateriel = new List<Materiel>();

            foreach (SearchMateriel_Result one in maListeBDD)
            {
                Materiel temp = new Materiel();
                temp.id_materiel = one.id_materiel;
                temp.modele = one.modele;
                temp.num_serie = one.num_serie;

                ListeMateriel.Add(temp);
            }

            return ListeMateriel;
        }

        public IList<Societe> SearchSociete()
        {
            IList<SearchSociete_Result> maListeBDD;
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                maListeBDD = bdd.SearchSociete().ToList();
            }

            // Translation vers une liste de matériel

            IList<Societe> ListeSociete = new List<Societe>();

            foreach (SearchSociete_Result one in maListeBDD)
            {
                Societe temp = new Societe();
                temp.id_societe = one.id_societe;
                temp.nom_societe = one.nom_societe;
                temp.adresse_societe = one.adresse_societe;
                temp.email_societe = one.email_societe;
                temp.ville_societe = one.ville_societe;
                temp.cp_societe = one.cp_societe;
                temp.tel_societe = one.tel_societe;
                ListeSociete.Add(temp);
            }

            return ListeSociete;
        }

        public IList<Technicien> SearchTechnicien()
        {
            IList<SearchTechnicien_Result> maListeBDD;
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                maListeBDD = bdd.SearchTechnicien().ToList();
            }

            // Translation vers une liste de matériel

            IList<Technicien> ListeTechnicien = new List<Technicien>();

            foreach (SearchTechnicien_Result one in maListeBDD)
            {
                Technicien temp = new Technicien();
                temp.id_technicien = one.id_technicien;
                temp.nom = one.nom;
                temp.prenom = one.prenom;
                temp.id_materiel = one.id_materiel;
                temp.tel = one.tel;
                ListeTechnicien.Add(temp);
            }

            return ListeTechnicien;
        }

        public IList<Motif_intervention> SearchMotif()
        {
            IList<SearchMotif_Result> maListeBDD;
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                maListeBDD = bdd.SearchMotif().ToList();
            }

            // Translation vers une liste de motif

            IList<Motif_intervention> ListeMotif = new List<Motif_intervention>();

            foreach (SearchMotif_Result one in maListeBDD)
            {
                Motif_intervention temp = new Motif_intervention();
                temp.id_motif = one.id_motif;
                temp.libelle = one.libelle;
                ListeMotif.Add(temp);
            }

            return ListeMotif;
        }
        #endregion

        #region Update

        public void UPDCompte_rendu(Compte_rendu compte_rendu)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.UPDCompte_rendu(compte_rendu.id_compte_rendu,compte_rendu.note, compte_rendu.id_technicien, compte_rendu.id_societe);
            }
        }

        public void UPDSociete(Societe societe)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.UPDSociete(societe.id_societe, societe.nom_societe, societe.adresse_societe, societe.email_societe, societe.ville_societe, societe.cp_societe, societe.tel_societe);
            }
        }

        public void UPDIntervention(Intervention intervention)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.UPDIntervention(intervention.id_intervention, intervention.id_motif, intervention.date_intervention, intervention.id_compte_rendu, intervention.id_etat, intervention.id_technicien, intervention.id_societe);
            }
        }

        public void UPDTechnicien(Technicien technicien)
        {
            using (bdd_Daltons_ppe3Entities bdd = new bdd_Daltons_ppe3Entities())
            {
                bdd.UPDTechnicien(technicien.id_technicien,technicien.nom, technicien.prenom, technicien.id_materiel, technicien.tel);
            }
        }

        #endregion

    }
}
