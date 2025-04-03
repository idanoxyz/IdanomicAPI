using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Idanomic.Api.Models.Domain
{
    public class Deck
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public required string Name { get; set; }
        public required string Word { get; set; }
        
        [JsonPropertyName("forms")]
        public Dictionary<string, Dictionary<string, string>> Forms { get; set; } = new();
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? LastPracticedAt { get; set; }
        
        // Navigation properties
        public User? User { get; set; }
        public Template? Template { get; set; }
    }
}