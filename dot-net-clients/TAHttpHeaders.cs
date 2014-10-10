namespace TrackAbout.RestApi.Interface.Documentation
{
    public static class TAHttpHeaders
    {
        public const string Token = "X-Token";
        
        public const string ApiKey = "X-API-Key";

        public const string ImpersonateUser = "X-Impersonate-User";

        /// <summary>
        /// Affects how to interpret the value of the X-Impersonate-User 
        /// header. In not supplied, default value is Username.
        /// </summary>
        public const string ImpersonationMethod = "X-Impersonation-Method";

        /// <summary>
        /// Used for tracking the same data across multiple requests.
        /// When retrying a request, send the same id to avoid creating
        /// multiple sync problems.
        /// </summary>
        public const string CorrelationId = "X-CorrelationId";
    }
}
