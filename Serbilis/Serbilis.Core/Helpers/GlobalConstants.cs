using System;
using System.Collections.Generic;
using System.Text;

namespace Serbilis.Core.Helpers
{
    public static class GlobalConstants
    {
        public const string DocClassBirth = "B";
        public const string DocClassMarriage = "M";
        public const string DocClassDeath = "D";
        public const string Pdve = "PDVE";
        public const string Vei = "VEI";
        public const string DefaultCountryCode = "608";
        public const string DefaultProvinceCode = "999";
        public const string DefaultMuniciplaityCode = "99";
        public const string DefaultPreGender = "U";
        public const string Defaultvariableunknown = "<UNKNOWN>";
        public const string DefaultRequestStatusCode = "TP";
        public const string DefaultRequestSource = "AA";
        public const string DefaultConversionflag = "N";
        public const string DefaultLGUOutletCode = "006";
        public const string DefaultCentralOutletCode = "003";
        public const string defaultBooleanconstantyes = "YES";
        public const string DefaultRequestType = "PA";
        public const string DefaultRequesterType = "PU";
        public const string DefaultvariableunknownValue = "ÿ";

        public static string DocumentType { get; set; } = "";
        //public const string DocumentType = "";
        public const string ResponseMessageSuccess = "Success";
        public const string ActiveStatus = "A";
        public const string Session_QRDeatils = "QRDeatils";
        public const string ContentTypePDF = "application/pdf";
        public const string InvalidUser = "Please contact System Administrator";
        public const string InvalidFunction = "Application security role matrix is not defined";
        public const string TemplateRV_UNSubjectConstant = "UNCONVERTED";
        public const string ForeignEmailTemplateSubject = "Dispatch Notice";
        public const string EmailNotSent = "Email not sent";
        public const string TOEMAILNULL = "To Email is not defined";
        public const string NoRecordsFound = "No Record Found.";
        public const string EmailSubject = "PSA Serbilis Notice";
        public const string UNDERPAYMENT = "UNDERPAYMENT";
        public const string OVERPAYMENT = "OVERPAYMENT";
        public const string INVALIDREFNO = "INVALID REF NO";
        public const string INVALIDPAYMENTCHANNEL = "INVALID PAYMENT CHANNEL";
        public const string PREVIOUSLYPAID = "PREVIOUSLY PAID";
        public const string smtpServerAddress = "na-mailrelay-t3.na.uis.unisys.com";
        public const string fromAddress = "info@psaserbilis.com.ph";


        #region  Asset Management
        public const string RecordsImportSuccess = " records imported successfully";
        public const string FileInvalid = "The file being imported is invalid.";
        public const string SerialNoAlreadyExists = "Serial number already exists";
        public const string TagNoAlreadyExists = "Tag number already exists";
        public const string IntheFileSerialno = "In the file Serial No ";
        public const string IntheFileTagno = "In the file Tag No ";
        public const string TagNoOrSerialNoExists = " already existing in the system. Please correct the file and try importing again. Zero Records were imported.";
        public const string ImportFailed = "Import failed. Having Serial No ";
        public const string FileError = " in the file have error. :";
        #endregion

        public const string ResponseMessageFailed = "Failed";

        public const string GUIDValidation = "[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}";
        public const string DateValidation = "^(?:0?[1-9]|1[0-2])[/](?:[012]?[0-9]|3[01])[/](?:[0-9]{2}){1,2}$";
        public const string AlphaNumeric30Validation = @"^[\w\s\-\.'ñÑ]{1,30}$";
        public const string AlphaNumeric50Validation = @"^[\w\s\-\.'ñÑ]{1,50}$";

    }
}
