using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bank_Account_Opening_Form.Models
{
    public class Branch
    {
        [Key]
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
        public int BranchCityCode { get; set; }
        [ForeignKey("BranchCityCode")]
        public City City { get; set; }
    }
}
