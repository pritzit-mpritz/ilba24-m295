namespace M295_ILBA24.DTOs;

public record FilmRequestDto(
    string? Title,
    string? Description,
    int? ReleaseYear,
    int LanguageId,
    int? OriginalLanguageId,
    int RentalDuration,
    decimal RentalRate,
    int Length,
    decimal ReplacementCost,
    string? Rating
);