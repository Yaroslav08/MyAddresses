using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Constants.WebApiResponses
{
    public class APIUnauthorizedResponse : APIResponse
    {
        public APIUnauthorizedResponse() : base(false, 401, null, "Need auth", null)
        { }
    }
}