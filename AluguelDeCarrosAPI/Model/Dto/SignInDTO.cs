﻿using System.ComponentModel.DataAnnotations;

namespace AluguelDeCarrosAPI.Model.Dto
{
    public class SignInDTO
    {

        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}