using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Idanomic.Api.Models.DTOs
{
    // DTO for creating a new template
    public class CreateTemplateDto
    {
        [Required]
        public required string Name { get; set; }
        
        [Required]
        public required string Language { get; set; }
        
        [Required]
        public required string GrammaticalCategory { get; set; }
        
        [Required]
        public required Dictionary<string, List<string>> GrammaticalFields { get; set; }
    }
    
    // DTO for updating an existing template
    public class UpdateTemplateDto
    {
        public required string Name { get; set; }
        public required string Language { get; set; }
        public required string GrammaticalCategory { get; set; }
        public required Dictionary<string, List<string>> GrammaticalFields { get; set; }
    }
    
    // DTO for returning template details
    public class TemplateDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Language { get; set; }
        public required string GrammaticalCategory { get; set; }
        public required Dictionary<string, List<string>> GrammaticalFields { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    
    // DTO for a simplified template list view
    public class TemplateListItemDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Language { get; set; }
        public required string GrammaticalCategory { get; set; }
        public int DeckCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}