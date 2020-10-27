using Dapper;
using Serbilis.Application.Interfaces;
using Serbilis.Core.Helpers;
using Serbilis.Core.Models;
using Serbilis.DataAccess.Interfaces;
using Serbilis.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;

namespace Serbilis.Application
{
    public class SerbilisManager : ISerbilisManager
    {
        private readonly IDataService _dataService;
        public SerbilisManager(IDataService dataService)
        {
            _dataService = dataService;
            _windowsUser = WindowsIdentity.GetCurrent().Name;
        }

        private readonly string _windowsUser;
        private const string INSTITUTION_NAME = "ECENSUS";
        private const int CUSTOMER_CODE = 299;
        private long RequesterID;
        private const string TRAN_TYPE_CENOMAR = "CE";
        private const string TRAN_TYPE_CENODEATH = "CD";
        private const string TRANSTATUS_WAITPYMNT = "WP";
        private const string REFERENCE_NO = "";
        private const string ACCESSNO_REQUIRED = "Access No and Password are required";
        private const string ACCESSNO_VERIFIED = "Access Verified";
        private const string TRANSTATUS_WAITDOCMNT = "WD";
        private const string PYMT_STATUS = "U";
        private const string TRAN_SOURCE = "WB";
        private const string NO_OF_PAGES = "1";
        private const string PRIM_TIN = "";
        private const string SEC_TIN = "";
        private const string DOC_FLAG = " ";


        public IEnumerable<RequestPurposeModel> GetRequestPurposeModel()
        {
            var requestDetails =
                _dataService.QuerymultipleRecords(new List<ModelBase>(new ModelBase[] { new RequestPurposeModel() }),
                    StoredProcedure.GetRequestPurpose,
                    ConnectionType.CivilRegistrySystem) ?? new List<RequestPurposeModel>();
            return requestDetails?.Cast<RequestPurposeModel>().ToArray();
        }

        public string InsertRequesterDetail(RequesterDetailModel requesterModel)
        {
            try
            {
                if (requesterModel == null) return "empty";
                if (!string.IsNullOrEmpty(requesterModel.AccessNo))
                    return InsertBREQsRequesterDetail(requesterModel);

                var param = new DynamicParameters();
                param.Add("@RequestSeriesNo ", requesterModel.TransactionSeriesNo);
                param.Add("@LongName", INSTITUTION_NAME);
                param.Add("@LastName", requesterModel.LastName);
                param.Add("@FirstName", requesterModel.FirstName);
                param.Add("@MiddleInitial", requesterModel.MiddleInitial);
                param.Add("@AddressLine1", requesterModel.AddressLine1);
                param.Add("@AddressLine2", requesterModel.AddressLine2);
                param.Add("@Email", requesterModel.EmailAddress);
                param.Add("@CountryCode", requesterModel.CountryCode);
                if (Convert.ToInt16(requesterModel.CountryCode) == 608)
                {
                    param.Add("@ProvinceCode", requesterModel.ProvinceCode);
                    param.Add("@MunicipalCode", requesterModel.CityMunicipalityCode);
                }
                else
                {
                    param.Add("@ProvinceCode", null);
                    param.Add("@MunicipalCode", null);
                }

                param.Add("@MobileNo", requesterModel.TelephoneNumber);
                param.Add("@ZipCode", requesterModel.ZipCode);
                param.Add("@TIN", requesterModel.TIN);
                param.Add("@CustomerNo", CUSTOMER_CODE);
                param.Add("@QueueTicketNo", requesterModel.QueueTicketNumber);
                param.Add("@CreatedBy", _windowsUser);
                _dataService.Exec(StoredProcedure.InsertRequester, ConnectionType.CivilRegistrySystem, param);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string InsertBREQsRequesterDetail(RequesterDetailModel requesterModel)
        {
            try
            {
                if (requesterModel == null) return "empty";

                var param = new DynamicParameters();
                param.Add("@LastName", requesterModel.LastName);
                param.Add("@FirstName", requesterModel.FirstName);
                param.Add("@MiddleInitial", requesterModel.MiddleInitial);
                param.Add("@AddressLine1", requesterModel.AddressLine1);
                param.Add("@AddressLine2", requesterModel.AddressLine2);
                param.Add("@CountryCode", requesterModel.CountryCode);
                if (Convert.ToInt16(requesterModel.CountryCode) == 608)
                {
                    param.Add("@ProvinceCode", requesterModel.ProvinceCode);
                    param.Add("@MunicipalCode", requesterModel.CityMunicipalityCode);
                }
                else
                {
                    param.Add("@ProvinceCode", null);
                    param.Add("@MunicipalCode", null);
                }

                param.Add("@ContactNo", requesterModel.TelephoneNumber);
                param.Add("@ZipCode", requesterModel.ZipCode);
                param.Add("@AccessNo", requesterModel.AccessNo);
                param.Add("@RequesterID", 0, DbType.Int64, ParameterDirection.Output);
                RequesterID = _dataService.Exec(StoredProcedure.BreqsInsertRequester,
                    ConnectionType.CivilRegistrySystem, param);
                RequesterID = param.Get<long>("@RequesterID");
                return RequesterID.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string InsertRequestDetail(RequestDetailModel requestModel)
        {
            if (requestModel == null) return "request is empty";
            if (!string.IsNullOrEmpty(requestModel.AccessNo))
                return InsertBREQSRequestDetail(requestModel);

            var param = new DynamicParameters();
            if (requestModel == null) return null;

            var transType = requestModel.TransactionType;
            var transsubtype = requestModel.TransactionSubType;
            switch (requestModel.Certificate)
            {
                case CertificateType.Birth:
                case CertificateType.EEBirth:
                    param.Add("@DocumentType");
                    param.Add("@DocumentSubType");
                    param.Add("@RequestSubType", transsubtype);
                    param.Add("@RequestType", transType);
                    break;

                case CertificateType.Marriage:
                case CertificateType.EEMarriage:
                    param.Add("@DocumentType");
                    param.Add("@DocumentSubType");
                    param.Add("@RequestSubType", transsubtype);
                    param.Add("@RequestType", transType);
                    break;
                case CertificateType.Death:
                case CertificateType.EEDeath:
                    param.Add("@DocumentType");
                    param.Add("@DocumentSubType");
                    param.Add("@RequestSubType", transsubtype);
                    param.Add("@RequestType", transType);
                    break;
                case CertificateType.CENOMAR:
                    param.Add("@DocumentType");
                    param.Add("@DocumentSubType");
                    switch (requestModel.TransactionType)
                    {
                        case "CI":
                            param.Add("@RequestType", TRAN_TYPE_CENOMAR);
                            param.Add("@RequestSubType", transsubtype);
                            break;
                        case "VO":
                            param.Add("@RequestType", transType);
                            param.Add("@RequestSubType", transsubtype);
                            break;
                    }

                    break;
                case CertificateType.CenoDeath:
                    param.Add("@DocumentType");
                    param.Add("@DocumentSubType");
                    switch (requestModel.TransactionType)
                    {
                        case "CI":
                            param.Add("@RequestType", TRAN_TYPE_CENODEATH);
                            param.Add("@RequestSubType", transsubtype);
                            break;
                        case "VO":
                            param.Add("@RequestType", transType);
                            param.Add("@RequestSubType", transsubtype);
                            break;
                    }

                    break;
                default:
                    return null;
            }


            param.Add("@SeriesNo", requestModel.TransactionSeriesNo);
            param.Add("@OutletCode", requestModel.OutletCode);
            param.Add("@RequestDate", DateTime.Now);
            param.Add("@WebReferenceNo", REFERENCE_NO);
            param.Add("@CreatedBy", _windowsUser);
            param.Add("@RequestSource", requestModel.OutletCode == "992" ? "WP" : TRAN_SOURCE);
            if (requestModel.TransactionType == "EE")
            {
                param.Add("@RequestStatusCode", TRANSTATUS_WAITDOCMNT);
            }
            else
            {
                param.Add("@RequestStatusCode", TRANSTATUS_WAITPYMNT);
            }


            param.Add("@ConversionFlag", string.IsNullOrEmpty(requestModel.ConvertedFlag) ? "Y" : requestModel.ConvertedFlag);


            param.Add("@RequestPurposeCode", requestModel.RequestPurpose);
            param.Add("@PurposeParticulars", requestModel.PurposeParticulars);
            param.Add("@RelationshipType", requestModel.RequestRelationship);
            param.Add("@PaymentStatusCode", PYMT_STATUS);

            param.Add("@NoOfPages", NO_OF_PAGES);
            param.Add("@Copies", requestModel.Copies);
            param.Add("@DocumentFlag", DOC_FLAG);
            param.Add("@EventDate", requestModel.EventDate);
            param.Add("@CountryCode", requestModel.CountryCode);
            param.Add("@ProvinceCode", requestModel.ProvinceCode);
            param.Add("@MunicipalCode", requestModel.MunicipalCode);
            param.Add("@PriLastName", requestModel.PrimaryLastName);
            param.Add("@PriFirstName", requestModel.PrimaryFirstName);
            param.Add("@PriMiddleName", requestModel.PrimaryMiddleName);
            param.Add("@PriTIN", PRIM_TIN);
            param.Add("@PriGender ", requestModel.PrimarySex);
            param.Add("@SecLastName", requestModel.SecondaryLastName);
            param.Add("@SecFirstName", requestModel.SecondaryFirstName);
            param.Add("@SecMiddleName", requestModel.SecondaryMiddleName);
            param.Add("@SecTIN", SEC_TIN);
            param.Add("@AuxLastName", requestModel.AuxLastName);
            param.Add("@AuxFirstName", requestModel.AuxFirstName);
            param.Add("@AuxMiddleName", requestModel.AuxMiddleName);


            var transactionSeqNo = 0;

            param.Add("@TranSeqNo", transactionSeqNo, DbType.Int32, ParameterDirection.Output);
            param.Add("@BatchReferenceNumber", "", DbType.String, ParameterDirection.Output);
            _dataService.Exec(StoredProcedure.InsertRequest, ConnectionType.CivilRegistrySystem, param);
            string batchRefNumber = param.Get<string>("@BatchReferenceNumber");
            //var seqLength = transactionSeqNo.ToString().Length;
            //return Hyphenate(requestModel.TransactionSeriesNo +
            //    Stuff("000", 3 - seqLength, seqLength, transactionSeqNo.ToString()), 4);
            return batchRefNumber;
        }

        public string InsertBREQSRequestDetail(RequestDetailModel requestModel)
        {
            try
            {
                var param = new DynamicParameters();
                if (requestModel == null) return null;

                var transType = requestModel.TransactionType;
                var transsubtype = requestModel.TransactionSubType;
                param.Add("@RequesterId", requestModel.RequesterID);
                switch (requestModel.Certificate)
                {
                    case CertificateType.Birth:
                        param.Add("@RequestSubType", transsubtype);
                        param.Add("@RequestType", transType);
                        break;

                    case CertificateType.Marriage:
                        param.Add("@RequestSubType", transsubtype);
                        param.Add("@RequestType", transType);
                        break;
                    case CertificateType.Death:
                        param.Add("@RequestSubType", transsubtype);
                        param.Add("@RequestType", transType);
                        break;
                    case CertificateType.CENOMAR:
                        switch (requestModel.TransactionType)
                        {
                            case "CI":
                                param.Add("@RequestType", TRAN_TYPE_CENOMAR);
                                param.Add("@RequestSubType", transsubtype);
                                break;
                            case "VO":
                                param.Add("@RequestType", transType);
                                param.Add("@RequestSubType", transsubtype);
                                break;
                        }

                        break;
                    case CertificateType.CenoDeath:
                        switch (requestModel.TransactionType)
                        {
                            case "CI":
                                param.Add("@RequestType", TRAN_TYPE_CENODEATH);
                                param.Add("@RequestSubType", transsubtype);
                                break;
                            case "VO":
                                param.Add("@RequestType", transType);
                                param.Add("@RequestSubType", transsubtype);
                                break;
                        }

                        break;
                    default:
                        return null;
                }

                param.Add("@RequestDate", DateTime.Now);
                param.Add("@RequestPurposeCode", requestModel.RequestPurpose);
                param.Add("@PurposeParticulars", "cccn");
                param.Add("@Copies", Convert.ToInt16(requestModel.Copies));
                param.Add("@EventDate", requestModel.EventDate);
                //param.Add("@EventDate", requestModel.EventDate);
                param.Add("@CountryCode", requestModel.CountryCode);
                if (Convert.ToInt16(requestModel.CountryCode) == 608)
                {
                    param.Add("@ProvinceCode", requestModel.ProvinceCode);
                    param.Add("@MunicipalCode", requestModel.MunicipalCode);
                }
                else
                {
                    param.Add("@ProvinceCode", null);
                    param.Add("@MunicipalCode", null);
                }

                param.Add("@PriLastName", requestModel.PrimaryLastName);
                param.Add("@PriFirstName", requestModel.PrimaryFirstName);
                param.Add("@PriMiddleName", requestModel.PrimaryMiddleName);
                param.Add("@PriGender ", requestModel.PrimarySex);
                param.Add("@SecLastName", requestModel.SecondaryLastName);
                param.Add("@SecFirstName", requestModel.SecondaryFirstName);
                param.Add("@SecMiddleName", requestModel.SecondaryMiddleName);
                param.Add("@AuxLastName", requestModel.AuxLastName);
                param.Add("@AuxFirstName", requestModel.AuxFirstName);
                param.Add("@AuxMiddleName", requestModel.AuxMiddleName);
                param.Add("@AccessNo", requestModel.AccessNo);
                param.Add("@ID", 0, DbType.Int64, ParameterDirection.Output);
                _dataService.Exec(StoredProcedure.BreqsInsertRequest, ConnectionType.CivilRegistrySystem, param);
                return param.Get<long>("@ID").ToString();
            }
            catch (Exception exe)
            {
                return exe.ToString();
            }
        }
    }
}
