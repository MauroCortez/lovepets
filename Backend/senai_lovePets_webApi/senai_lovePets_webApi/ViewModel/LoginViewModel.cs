using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Informe o seu E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a sua Senha!")]
        public string Senha { get; set; }
    }
}
