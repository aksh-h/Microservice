using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Serbilis.Core.Models
{
    public class RequesterDetailModel
    {

        public string TransactionNo { get; set; }


        public string TransactionSeriesNo { get; set; }


        public string OutletCode { get; set; }


        public int CustomerCode { get; set; }


        public string RequesterType { get; set; }


        public string ReceiveResultMode { get; set; }


        public string InstitutionName { get; set; }


        public string LastName { get; set; }


        public string FirstName { get; set; }


        public string LongName { get; set; }


        public string MiddleInitial { get; set; }


        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set; }


        public string EmailAddress { get; set; }


        public string CountryCode { get; set; }


        public string ProvinceCode { get; set; }


        public string FormattedProvinceCode { get; set; }


        public string CityMunicipalityCode { get; set; }


        public string TelephoneNumber { get; set; }


        public string ZipCode { get; set; }


        public string TIN { get; set; }


        public DateTime RequestDate { get; set; }


        public string QueueTicketNumber { get; set; }


        public int TransactionCount { get; set; }


        public decimal TotalTransactionAmount { get; set; }


        public decimal TotalTransactionAmountUSD { get; set; }


        public string ORNo { get; set; }


        public string AccessNo { get; set; }


        public bool IsBreqs { get; set; }
    }
}
