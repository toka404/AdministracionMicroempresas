using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Service
{
    public interface IValidationService
    {
        public bool isEmailorUsernameRepeated(string param);
        public bool ValidateCedula(string ced);
        public bool ValidateEmail(string email);

    }
}
