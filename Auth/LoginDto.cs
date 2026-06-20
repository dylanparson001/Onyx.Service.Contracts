namespace Onyx.Shared.Contracts.Auth
{
    public sealed record LoginDto
    {
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
