using System;
using System.Collections.Generic;

namespace Idanomic.Api.Models.Domain
{
    public class Deck
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public required string Word { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastPracticedAt { get; set; }
        
        // The content stores the structured data from AI
        public required DeckContent Content { get; set; }
        
        // Navigation properties
        public required Template Template { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
    }
}