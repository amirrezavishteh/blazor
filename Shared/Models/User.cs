
using System;
using System.ComponentModel.DataAnnotations;

namespace P8.Shared
{
    public class User 
    {
        public int ID { get; set;}
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long.")]
        public string FullName {get; set;}
        [Required]

        public string Gender {get ;set;}
        [Required]

        public int PhoneNumber {get; set;}
        [Required]
        public string Address {get; set;}
        public int count;
        public int credit;
        // public string FullAddress => this.Address;
}
}
