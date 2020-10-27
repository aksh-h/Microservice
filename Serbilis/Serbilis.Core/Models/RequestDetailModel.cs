using Serbilis.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Serbilis.Core.Models
{
    public class RequestDetailModel : ModelBase
    {

        public string TransactionSeriesNo { get; set; }


        public string TransactionNo { get; set; }


        public string TransactionSequenceNo { get; set; }


        public string OutletCode { get; set; }


        public string ReferenceNo { get; set; }


        public string DocType { get; set; }


        public string DocSubType { get; set; }


        public string TransactionType { get; set; }


        public string TransactionTypeDescription { get; set; }


        public string TransactionSubType { get; set; }


        public string TransactionStatus { get; set; }


        public string PaymentStatus { get; set; }


        public string TransactionSource { get; set; }


        public string RequestPurpose { get; set; }


        public string PurposeParticulars { get; set; }


        public string RequestType { get; set; }

        public string RequestSubType { get; set; }


        public string RequestRelationship { get; set; }


        public string ConvertedFlag { get; set; }


        public string ResultType { get; set; }


        public string NoOfPages { get; set; }


        public string Copies { get; set; }


        public string EventDate { get; set; }


        public string EventPlace { get; set; }


        public string CountryCode { get; set; }


        public string ProvinceCode { get; set; }


        public string FormattedProvinceCode { get; set; }


        public string MunicipalCode { get; set; }


        public string PrimaryLastName { get; set; }


        public string PrimaryFirstName { get; set; }


        public string PrimaryMiddleName { get; set; }


        public string PrimaryBREN { get; set; }


        public string PrimarySex { get; set; }


        public string SecondaryLastName { get; set; }


        public string SecondaryFirstName { get; set; }


        public string SecondaryMiddleName { get; set; }


        public string SecondaryBREN { get; set; }


        public string AuxLastName { get; set; }


        public string AuxFirstName { get; set; }


        public string AuxMiddleName { get; set; }

        //[DataMember]
        //public string RegDate { get; set; }

        public string RegStatus { get; set; }


        public string PrimaryTIN { get; set; }


        public string SecondaryTIN { get; set; }


        public string EncodedBy { get; set; }


        public string CollectedBy { get; set; }


        public string ProcessedBy { get; set; }


        public string ReleasedBy { get; set; }


        public string DocFlag { get; set; }


        public string CustomerNo { get; set; }


        public string Name { get; set; }


        public decimal TransactionAmount { get; set; }


        public decimal UnitCost { get; set; }


        public string TransactionCurrency { get; set; }


        public DateTime RequestDate { get; set; }


        public string RequestLastName { get; set; }


        public string RequestFirstName { get; set; }


        public string RequestMiddleName { get; set; }


        public string RequestName { get; set; }


        public string LongName { get; set; }


        public decimal BaseAmount { get; set; }


        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set; }


        public string EmailAddress { get; set; }


        public string MailingAddress { get; set; }


        public string ZipCode { get; set; }


        public decimal TransactionAmountUSD { get; set; }


        public string TelephoneNumber { get; set; }


        public string MunicipalityCode { get; set; }


        public string TimeStart { get; set; }


        public string TimeEnd { get; set; }


        public string ORNo { get; set; }


        public string CRSCopyNo { get; set; }


        public int NumberOfSECPA { get; set; }


        public string ImageId { get; set; }


        public int ReprintCounter { get; set; }


        public string PrimaryCRN { get; set; }


        public string SecondaryCRN { get; set; }


        public string EnrollTransactionNo { get; set; }


        public int Priority { get; set; }


        public string EmployeeId { get; set; }


        public CertificateType Certificate { get; set; }


        public bool isBreqs { get; set; }


        public string AccessNo { get; set; }


        public int RequesterID { get; set; }


        public string SelectedCity { get; set; }


        public string SelectedProvince { get; set; }


        public string PriName { get; set; }


        public string BmdDate { get; set; }


        public string FatherName { get; set; }


        public string MotherName { get; set; }

        public string IsFeedbackForm { get; set; }

        public string PriLastName { get; set; }

        public string StatusMessage { get; set; }

        public string PaymentStatusCode { get; set; }


        public string LastName { get; set; }

        public string FirstName { get; set; }



        public string Result { get; set; }


        public string Status { get; set; }


        public string DateProcessed { get; set; }


        public string DocumentOwner { get; set; }


        public byte[] OtherResultImage { get; set; }

        public object OtherResultImage64 { get; set; }
        //[DataMember]
        //public string OtherResultImage { get; set; }

        public string RequestSeriesNo { get; set; }

        public string SequenceNo { get; set; }

        public string JobRequestNo { get; set; }


        public int APIType { get; set; }

        public byte[] ImageArray { get; set; }


        public string DocumentOwnerName { get; set; }

        public string PlaceofEvent { get; set; }

        public string DocumentType { get; set; }




        public string EEReferenceNumber { get; set; }



        public string RegistryNumber { get; set; }



        public string RegistryBookType { get; set; }

        public string LCROName { get; set; }

        public string LCROProvince { get; set; }



        public string LCROCity { get; set; }

        public string LCROProvinceCity { get; set; }

        public string Date { get; set; }


        public string EndorseTo { get; set; }



        public string EndorseOffice { get; set; }

        public string EndorseAddressLine1 { get; set; }

        public string EndorseAddressLine2 { get; set; }

    }
}
