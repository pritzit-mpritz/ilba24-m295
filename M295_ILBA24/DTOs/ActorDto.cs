namespace M295_ILBA24.DTOs;

public record BaseActorDto(
    int ActorId,
    string FirstName,
    string LastName,
    DateTime LastUpdate
);

public record FullActorDto(
    int ActorId,
    string FirstName,
    string LastName,
    DateTime LastUpdate,
    ICollection<BaseFilmDto> Films
) : BaseActorDto(ActorId, FirstName, LastName, LastUpdate);

public record ActorResponseDto(
    int ActorId,
    string FirstName,
    string LastName,
    DateTime LastUpdate,
    ICollection<BaseFilmDto> Films
): BaseActorDto(ActorId, FirstName, LastName, LastUpdate);