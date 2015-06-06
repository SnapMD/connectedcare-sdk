namespace SnapMD.ConnectedCare.Sdk.Models
{
    public class ApiResponse : ApiResponse<object>
    {
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}