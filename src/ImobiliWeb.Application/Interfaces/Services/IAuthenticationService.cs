﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobiliWeb.Application.Interfaces.Services
{
    public interface IAuthenticationService
    {
        string GenerateToken(string userId, string email);
    }
}
