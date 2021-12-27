using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceTracker.Entities
{
    public class Speaker : IValidatableObject
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
        [StringLength(maximumLength: 500, MinimumLength = 10)]
        public string Description { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]


        public string EmailAddress { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]


        public string PhoneNumber { get; set; }
        public bool IsStaff { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            if(EmailAddress != null && EmailAddress.EndsWith("TechnologyLiveConference.com", StringComparison.InvariantCultureIgnoreCase))
            {
                var item = new ValidationResult("Technology Live Conference staff should not use their conference email addresses.");
               result.Add(item);
            }
            return result;
        }
    }
}