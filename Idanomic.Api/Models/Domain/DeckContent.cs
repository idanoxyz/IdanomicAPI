// Idanomic.Api/Models/Domain/DeckContent.cs
using System.Text.Json;
using System.Text.Json.Serialization;

public class DeckContent
{
    public int Id { get; set; }
    public int DeckId { get; set; }
    
    public required string Language { get; set; }
    public required string GrammaticalCategory { get; set; }
    public required string Word { get; set; }
    
    // Store the full structure returned by AI
    [JsonExtensionData]
    public required Dictionary<string, JsonElement> DynamicContent { get; set; }
    
    // Additional property to store table structure information
    public required TableStructure TableStructure { get; set; }
    
    // Navigation property
    public required Idanomic.Api.Models.Domain.Deck Deck { get; set; }
}

// New class to define table structure
public class TableStructure
{
    public int Id { get; set; }
    public int DeckContentId { get; set; }
    
    // Headers for rows (like "nominative", "genitive", etc. in the Latin example)
    public required List<string> RowHeaders { get; set; }
    
    // Headers for columns (like "singular", "plural" in both examples)
    public required List<string> ColumnHeaders { get; set; }
    
    // Nested headers (like "first", "second", "third" under singular/plural in the French example)
    public required Dictionary<string, List<string>> NestedColumnHeaders { get; set; }
    
    // Row groups (like "indicative" in the French example that spans multiple rows)
    public required List<RowGroup> RowGroups { get; set; }
    
    // Navigation property
    public required DeckContent DeckContent { get; set; }
}

public class RowGroup
{
    public int Id { get; set; }
    public int TableStructureId { get; set; }
    
    public required string Name { get; set; }  // Like "indicative"
    public required List<string> ChildRows { get; set; }  // Like "present" that goes under "indicative"
    
    // Navigation property
    public required TableStructure TableStructure { get; set; }
}