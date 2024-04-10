namespace MsSqlLib.Application.Common.Models
{
    public class ServiceError
    {
        public string Message { get;}
        public int StatusCode { get;}

        public ServiceError(string message, int statusCode) => 
            (Message, StatusCode ) = (message, statusCode);

        public static ServiceError Default => new(ServiceConstants.Error.Default, ServiceConstants.StatusCode.Default);
        public static ServiceError NotFound => new(ServiceConstants.Error.NotFound, ServiceConstants.StatusCode.NotFound);
    }
}
