using Anun.SHARED.Entities;


namespace Anun.SHARED.DTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;

        public DateTime Expiration { get; set; }
    }
}
