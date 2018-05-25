using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace API_Daltons
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        #region Add

        [OperationContract]
        int AddCompte_Rendu(Compte_rendu compte_rendu);

        [OperationContract]
        int AddIntervention(Intervention intervention);

        //[OperationContract]
     //   void AddMateriel(Materiel materiel);

        [OperationContract]
        int AddSociete(Societe societe);

        [OperationContract]
        int AddTechnicien(Technicien technicien);
        #endregion

        #region Delete

        [OperationContract]
        void DeleteCompte_Rendu(Compte_rendu compte_rendu);

        [OperationContract]
        void DeleteIntervention(Intervention intervention);

        [OperationContract]
        void DeleteMateriel(Materiel materiel);

        [OperationContract]
        void DeleteSociete(Societe societe);

        [OperationContract]
        void DeleteTechnicien(Technicien technicien);
        #endregion

        #region Search

        [OperationContract]
        IList<Compte_rendu> SearchCompte_rendu();

        [OperationContract]
        IList<Intervention> SearchIntervention();

        [OperationContract]
        IList<Materiel> SearchMateriel();

        [OperationContract]
        IList<Societe> SearchSociete();

        [OperationContract]
        IList<Technicien> SearchTechnicien();

        [OperationContract]
        IList<Motif_intervention> SearchMotif();
        #endregion

        #region Update

        [OperationContract]
        void UPDSociete(Societe societe);

        [OperationContract]
        void UPDCompte_rendu(Compte_rendu compte_rendu);

        [OperationContract]
        void UPDTechnicien(Technicien technicien);

        [OperationContract]
        void UPDIntervention(Intervention intervention);

        #endregion
    }
}
