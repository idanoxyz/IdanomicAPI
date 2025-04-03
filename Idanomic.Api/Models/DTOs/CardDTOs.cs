using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Idanomic.Api.Models.DTOs
{
    // DTO for creating a new card
    public class CreateCardDto
    {
        [Required]
        public int DeckId { get; set; }
        
        [Required]
        public required string Front { get; set; }
        
        [Required]
        public required string Back { get; set; }
        
        public required string GrammaticalForm { get; set; }
        public int OrderIndex { get; set; }
    }
    
    // DTO for updating an existing card
    public class UpdateCardDto
    {
        public required string Front { get; set; }
        public required string Back { get; set; }
        public required string GrammaticalForm { get; set; }
        public int? OrderIndex { get; set; }
    }
    
    // DTO for returning card details
    public class CardDto
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public required string Front { get; set; }
        public required string Back { get; set; }
        public required string GrammaticalForm { get; set; }
        public int OrderIndex { get; set; }
        public int TimesReviewed { get; set; }
        public int TimesCorrect { get; set; }
        public DateTime? LastReviewedAt { get; set; }
    }
    
    // DTO for recording practice results for a specific card
    public class CardPracticeResultDto
    {
        public int CardId { get; set; }
        public bool Correct { get; set; }
    }
    
    // DTO for a batch of practice results
    public class BatchCardPracticeResultDto
    {
        public int DeckId { get; set; }
        public required List<CardPracticeResultDto> Results { get; set; }
    }
}