﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Constants.WebApiResponses
{
    public class APIInternalServerErrorResponse : APIResponse
    {
        public APIInternalServerErrorResponse() : base(false, 500, null, "Internal erver error", null)
        { }
    }
}