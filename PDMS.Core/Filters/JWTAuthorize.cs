﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDMS.Core.Filters
{
    public class JWTAuthorizeAttribute : AuthorizeAttribute
    {
        public JWTAuthorizeAttribute() : base()
        {

        }
    }
}
