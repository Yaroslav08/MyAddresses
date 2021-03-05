using System;
using System.Collections.Generic;
using System.Text;

namespace MyAddresses.Constants
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string VersionV1 = "v1";

        public const string Base = Root + "/" + VersionV1;

        public static class Users
        {
            public const string GetAll = Base + "/users";

            public const string Get = Base + "/users/{userId}";
        }
    }
}