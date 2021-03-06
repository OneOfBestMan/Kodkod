﻿using System;
using Microsoft.IdentityModel.Tokens;

namespace Kodkod.Web.Api.Authentication
{
    public class JwtTokenConfiguration
    {
        public SymmetricSecurityKey SecurityKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public SigningCredentials SigningCredentials { get; set; }

        public TimeSpan Expiration { get; set; }
    }
}
