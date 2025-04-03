// Idanomic.Api/Models/Domain/Template.cs
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
        public required string GrammaticalCategory { get; set; }
        
        [JsonPropertyName("grammaticalFields")]
        public required Dictionary<string, List<string>> GrammaticalFields { get; set; }
        
        public required string Prompt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // Navigation properties
        public required User User { get; set; }
        public required List<Deck> Decks { get; set; }
    }
}