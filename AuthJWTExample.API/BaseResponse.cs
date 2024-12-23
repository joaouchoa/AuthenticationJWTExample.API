namespace AuthJWTExample.API
{
    public class BaseResponse
    {
        public int StatusCode { get; set; }
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }
    }
}
