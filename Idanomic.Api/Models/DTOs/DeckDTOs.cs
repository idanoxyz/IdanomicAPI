using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Idanomic.Api.Models.DTOs
{
    // DTO for creating a new deck
    public class CreateDeckDto
    {
        [Required]
        public int TemplateId { get; set; }
        
        [Required]
        public required string Word { get; set; }
    }
    
    // DTO for updating an existing deck
    public class UpdateDeckDto
    {
        public required string Word { get; set; }
        public required Dictionary<string, JsonElement> Content { get; set; }
    }
    
    // DTO for returning deck details
    public class DeckDto
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public required string TemplateName { get; set; }
        public required string Word { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastPracticedAt { get; set; }
        
        // Basic deck info
        public required string Language { get; set; }
        public required string GrammaticalCategory { get; set; }
        
        // Dynamic content from AI
        public required Dictionary<string, JsonElement> Content { get; set; }
    }
    
    // DTO for a simplified deck list view
    public class DeckListItemDto
    {
        public int Id { get; set; }
        public required string Word { get; set; }
        public required string Language { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastPracticedAt { get; set; }
    }
    
    // DTO for recording practice sessions
    public class RecordPracticeDto
    {
        public int DeckId { get; set; }
        public bool Completed { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalCards { get; set; }
    }
}