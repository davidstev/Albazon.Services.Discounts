using System.Net;

namespace Albazon.Services.Discounts.Api.Models.Dto
{
    public class ResponseDto
    {
        public object? Response { get; set; }
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get;set; } = HttpStatusCode.OK;
        public List<string> ValidationMessages { get; set; } = new List<string>();
    }
}
