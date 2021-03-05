using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Constants.WebApiResponses
{
    public class APIBadRequestResponse : APIResponse
    {
        public APIBadRequestResponse(string errormessage) : base(false, 400, null, errormessage, null)
        { }
    }
}