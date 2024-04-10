namespace MsSqlLib.Application.Common.Models
{
    public class ServiceResult<T> : ServiceResult
    {
        public T Data { get; set; }

        public ServiceResult(T data)
        {
            Data = data;
        }

        public ServiceResult(T data, ServiceError error) : base(error) =>
            (Data) = (data);

        public ServiceResult(ServiceError error) : base(error)
        {
        }
    }

    public class ServiceResult
    {
        public ServiceError Error { get; set; }

        public ServiceResult(ServiceError error)
        {
            if(error == null) 
            {
                Error = ServiceError.Default;
            }

            Error = error;
        }

        public ServiceResult() { }

        public static ServiceResult<T> Success<T>(T data) => new(data);

        public static ServiceResult<T> Failed<T>(T data, ServiceError error) => new(data, error);
    }
}
