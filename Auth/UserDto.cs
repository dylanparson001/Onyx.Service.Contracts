namespace Onyx.Shared.Contracts.Auth
{
    public class UserDto
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string Token { get; set; } = "";
    }
}
