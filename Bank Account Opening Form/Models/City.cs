using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bank_Account_Opening_Form.Models
{
    public class City
    {
        [Key]
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int CityStateCode { get; set; }
        [ForeignKey("CityStateCode")]
        public State State { get; set; }
    }
}
