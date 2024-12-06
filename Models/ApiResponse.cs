namespace HeartCoreAPI.Models
{
    public class ApiResponse
    {
        public int StatusCode { get; set; } = 200;
        public bool Success { get; set; } = true;
        public string Message { get; set; } = "successfully";
        public List<String> Errors { get; set; } = new List<String>();
        public dynamic? Data { get; set; } = null;
    }
}
