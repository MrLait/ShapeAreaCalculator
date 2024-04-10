namespace MsSqlLib.Application.Common.Models
{
    public static class ServiceConstants
    {
        public static class Error
        {
            public const string Default = "An exception occured.";
            public const string NotFound = "The requested data was not found on this server.";
        };

        public static class StatusCode
        {
            public const int Default = 999;
            public const int NotFound = 404;
        }
    }
}