﻿using Hospital.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.ModelVM
{
    public class CreateDoctorViewModel
    {
        [Required(ErrorMessage = "your first name is required")]
        [MaxLength(20, ErrorMessage = "must be less than 21")]
        [MinLength(3, ErrorMessage = " must be greater than 2")]
        [Display(Name = "Frist name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "your last name is required")]
        [MaxLength(20, ErrorMessage = "must be less than 21")]
        [MinLength(3, ErrorMessage = " must be greater than 2")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "phone number is required")]
        [RegularExpression(@"^(?:\+20|0)?(1[0125]\d{8})$", ErrorMessage = "invalid egyptian phone number")]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(10000,25000)]
        public decimal Salary { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Specialization is required")]
        [Display(Name = "Sepcialization")]
        public int SpecializationId { get; set; }

        public IEnumerable<Specialization>? Specializations { get; set; }
    }
}
