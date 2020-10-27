using System;
using System.Runtime.Serialization;

namespace Serbilis.Core.Models
{
    [Serializable]
    [DataContract]
    public class ModelBase : IDisposable
    {
        public ModelBase()
        {
        }

        [DataMember]
        public string MVUserName { get; set; }

        [DataMember]
        public string PaymentDateFrom { get; set; }

        [DataMember]
        public string PaymentDateTo { get; set; }

        [DataMember]
        public string PaymentSource { get; set; }

        [DataMember]
        public string PaymentSourceDescription { get; set; }

        [DataMember]
        public virtual string Code { get; set; }

        [DataMember]
        public virtual int ID { get; set; }


        [DataMember(EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CreatedBy { get; set; }


        [DataMember(EmitDefaultValue = false)]
        public DateTime? ModifiedOn { get; set; }


        [DataMember(EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }


        [DataMember(EmitDefaultValue = false)]
        public string EntityType { get; set; }

        [DataMember]
        public string UserID { get; set; }

        [DataMember]
        public int ReasonID { get; set; }

        [DataMember]
        public int? DefaultWorkUnitID { get; set; }

        [DataMember]
        public string DefaultOutletCode { get; set; }
        [DataMember]
        public string UserRoles { get; set; }

        [DataMember]
        public string Office { get; set; }
        [DataMember]
        public string Outlet { get; set; }

        [DataMember]
        public string DefaultOfficeCode { get; set; }
        [DataMember]
        public string HostName { get; set; }
        public void Dispose()
        {
        }
        [DataMember]
        public string Relationship { get; set; }
        [DataMember]
        public string PetitionReason { get; set; }
        [DataMember]
        public string PetitionGround { get; set; }
        [DataMember]
        public string PetitionType { get; set; }
        [DataMember]
        public string CourtName { get; set; }

        [DataMember]
        public string PaymentGroupID { get; set; }

        [DataMember]
        public string ReferenceNo { get; set; }
        [DataMember]
        public string PaymentDate { get; set; }

        [DataMember]
        public string PayorName { get; set; }

        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string ReasonType { get; set; }
        [DataMember]
        public int RequestInactive { get; set; }

    }
}