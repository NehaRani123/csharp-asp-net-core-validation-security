using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceTracker.Entities
{
    public class Speaker
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First name")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Description { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]


        public string EmailAddress { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]


        public string PhoneNumber { get; set; }
        public bool IsStaff { get; set; }
    }
}