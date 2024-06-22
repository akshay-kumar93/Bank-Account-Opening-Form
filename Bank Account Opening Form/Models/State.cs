using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank_Account_Opening_Form.Models
{
    public class State
    {
        [Key]
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
