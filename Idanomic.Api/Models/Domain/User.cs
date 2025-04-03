using System;
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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // Navigation properties
        public List<Template> Templates { get; set; } = new();
        public List<Deck> Decks { get; set; } = new();
    }
}