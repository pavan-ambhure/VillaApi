using System.Net;

namespace MyVillaAPI.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;

        public List<String> ErrorMessages { get; set; } = new List<string>();

        public Object Result { get; set; }
    }
}
