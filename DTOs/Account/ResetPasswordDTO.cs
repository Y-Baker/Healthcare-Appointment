﻿using System.ComponentModel.DataAnnotations;

namespace Medical.DTOs.Account
{
    public class ResetPasswordDTO
    {

        [Required(ErrorMessage = "password required")]
        [MinLength(6, ErrorMessage = "min len 6")]
        [MaxLength(10, ErrorMessage = "max len 10")]
        public string Password { get; set; }

        [Required(ErrorMessage = "confirm password required")]
        [MinLength(6, ErrorMessage = "min len 6")]
        [MaxLength(10, ErrorMessage = "max len 10")]
        [Compare("Password", ErrorMessage = "password not match")]
        public string ConfirmPassword { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}