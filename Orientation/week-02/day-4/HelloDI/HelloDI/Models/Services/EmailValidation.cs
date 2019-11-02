using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDI.Models
{
    public class EmailValidation
    {
        public bool IsValid { get; set; }
        public string Email { get; set; }

        public void ValidateEmail(string email)
        {
            if (email.Contains('@') && email.Contains('.'))
            {
                IsValid = true;
                return;
            }
            IsValid = false;
        }

    }
}
