using Microsoft.AspNetCore.Mvc;

namespace RestfulAPI.Identity.Contracts.Common;
public static class ApiRoutes
{
    public const string Api = "api";

    #region V1
    public static class V1
    {
        public const string Version = "v1";
        public const string Base = $"{Api}/{Version}";

        public static class Authentication
        {
            public const string SignUp = $"{Base}/signup";
            public const string SignIn = $"{Base}/signin";
        }
    }
    #endregion


}
