using System.Collections.Generic;

namespace Idanomic.Api.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        // Password hash, salt, etc. would be added in a real implementation
        public required string PasswordHash { get; set; }
        public required string Salt { get; set; }
        
        // Navigation property
        public required List<Template> Templates { get; set; }
    }
}