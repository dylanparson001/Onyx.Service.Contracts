namespace Onyx.Shared.Contracts.Auth

{
    public sealed record RegisterDto
    {
        public string Username { get; init; } = "";
        public string Password { get; init; } = "";
        public string? Email { get; init; } = "";
        public string Role { get; init; } = "";
    }
}