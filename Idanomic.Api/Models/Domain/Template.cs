using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Idanomic.Api.Models.Domain
{
    public class Template
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string Name { get; set; }
        public required string Language { get; set; }
        public required string Category { get; set; }
        
        [JsonPropertyName("fields")]
        public required Dictionary<string, List<string>> Fields { get; set; }
        
        public string? Prompt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // Navigation properties
        public User? User { get; set; }
        public List<Deck> Decks { get; set; } = new();
    }
}