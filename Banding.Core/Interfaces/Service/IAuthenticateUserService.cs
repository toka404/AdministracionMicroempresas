using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Service
{
    public interface IAuthenticateUserService
    {
        public List<Claim> Validate(string username, string password);

    }
}
