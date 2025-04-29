namespace M295_ILBA24.DTOs;

public record BaseFilmDto(
    int FilmId,
    string? Title,
    string? Description,
    int? ReleaseYear,
    int LanguageId,
    int? OriginalLanguageId,
    int RentalDuration,
    decimal RentalRate,
    int Length,
    decimal ReplacementCost,
    string? Rating,
    DateTime LastUpdate
);

public record FilmResponseDto(
    int FilmId,
    string? Title,
    string? Description,
    int? ReleaseYear,
    int LanguageId,
    int? OriginalLanguageId,
    int RentalDuration,
    decimal RentalRate,
    int Length,
    decimal ReplacementCost,
    string? Rating,
    DateTime LastUpdate,
    ICollection<FilmActorDto> FilmActors
) : BaseFilmDto(FilmId, Title, Description, ReleaseYear, LanguageId, OriginalLanguageId, RentalDuration, RentalRate,
    Length, ReplacementCost, Rating, LastUpdate);