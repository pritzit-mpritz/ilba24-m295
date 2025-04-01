namespace M295_ILBA24.DTOs;

public record BaseFilmDto(
    ushort FilmId,
    string? Title,
    string? Description,
    short? ReleaseYear,
    byte LanguageId,
    byte? OriginalLanguageId,
    byte RentalDuration,
    decimal RentalRate,
    ushort Length,
    decimal ReplacementCost,
    string? Rating,
    DateTime LastUpdate
    );