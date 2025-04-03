using System;
using System.Text.Json;

namespace Idanomic.Api.Models.Domain
{
public class Card
{
    public int Id { get; set; }
    public int DeckId { get; set; }
    
    // Core card content
    public required string Front { get; set; }
    public required string Back { get; set; }
    
    // Position information for tables
    public required string RowIdentifier { get; set; }  // e.g., "nominative" or "indicative.present"
    public required string ColumnIdentifier { get; set; }  // e.g., "singular" or "singular.first"
    
    // Additional content
    public required string Pronunciation { get; set; }  // For IPA representations
    public required string Notes { get; set; }
    
    // Metadata
    public int OrderIndex { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    // Study data
    public int TimesReviewed { get; set; }
    public int TimesCorrect { get; set; }
    public DateTime? LastReviewedAt { get; set; }
    
    // Navigation property
    public required Deck Deck { get; set; }
    }
}