using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace BangazonApi.Models
{
    public class Customer
    {

      [Key]
      public int CustomerId{get;set;}

      [Required]
      [DataType(DataType.Date)]
      public DateTime DateCreated{get;set;}
    
      [Required]
      [StringLength(60)]
      public string LastName{get;set;}
      
      [Required]
      [StringLength(60)]
      public string FirstName{get;set;}
      
      [StringLength(60)]
      public string StreetAddress {get;set;}

    }
}
  