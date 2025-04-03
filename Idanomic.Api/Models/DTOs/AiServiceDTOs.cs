using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Idanomic.Api.Models.DTOs
{
    // Request DTO for AI deck generation
    public class AiDeckGenerationRequest
    {
        public required string Prompt { get; set; }
        public required string Language { get; set; }
        public required string GrammaticalCategory { get; set; }
        public required string Word { get; set; }
        
        // Dynamic grammatical fields from the template
        [JsonExtensionData]
        public required Dictionary<string, object> GrammaticalFields { get; set; }
    }
    
    // Response DTO from AI service
    public class AiDeckGenerationResponse
    {
        public required string Language { get; set; }
        public required string GrammaticalCategory { get; set; }
        public required string Word { get; set; }
        
        // This allows for handling any structure returned by the AI
        [JsonExtensionData]
        public required Dictionary<string, JsonElement> DynamicContent { get; set; }
    }
    
    // DTO for handling AI service errors
    public class AiServiceErrorResponse
    {
        public required string ErrorCode { get; set; }
        public required string ErrorMessage { get; set; }
        public required Dictionary<string, string> AdditionalInfo { get; set; }
    }
    
    // Helper class for building prompt templates
    public class PromptTemplateBuilder
    {
        public static string BuildTemplate(string language, string grammaticalCategory, Dictionary<string, List<string>> grammaticalFields)
        {
            var fieldsJson = JsonSerializer.Serialize(grammaticalFields);
            
            return $"Given the following grammatical template for a language, please generate a deck of flashcards for the word '{{word}}' in all relevant grammatical cases and forms. " +
                   $"The template includes the language '{language}', the grammatical category '{grammaticalCategory}', and additional fields: {fieldsJson}. " +
                   $"Ensure the following format for your results, with each form correctly conjugated/declined as appropriate. " +
                   $"Return ONLY a valid JSON object that matches the expected structure. " +
                   $"Do not include any explanation, commentary, or extra text. Only return the JSON object itself.";
        }
    }
}