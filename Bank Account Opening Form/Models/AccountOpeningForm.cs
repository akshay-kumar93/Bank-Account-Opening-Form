using System.ComponentModel.DataAnnotations;
using System;

namespace Bank_Account_Opening_Form.Models
{
    public class AccountOpeningForm
    {
        [Key]
        public int FormNumber { get; set; }
        public DateTime FormFillingDate { get; set; }
        public TimeSpan FormFillingTime { get; set; }
        public int CustTitle { get; set; }
        public string CustFirstName { get; set; }
        public string CustMiddleName { get; set; }
        public string CustLastName { get; set; }
        public int CustSex { get; set; }
        public DateTime CustDateOfBirth { get; set; }
        public int CustAge { get; set; }
        public string CustStdCode { get; set; }
        public string CustTelephone { get; set; }
        public string CustMobile { get; set; }
        public string CustEmailId { get; set; }
        public int CustStateCode { get; set; }
        public int CustCityCode { get; set; }
        public int CustBranchCode { get; set; }
        public int CustAccountType { get; set; }
        public int CustPreferredLanguage { get; set; }
    }
}
