using System;
using System.Collections.Generic;

namespace M295_ILBA24.Entities;

public partial class Film
{
    public int FilmId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? ReleaseYear { get; set; }

    public int LanguageId { get; set; }

    public int? OriginalLanguageId { get; set; }

    public int RentalDuration { get; set; }

    public decimal RentalRate { get; set; }

    public int? Length { get; set; }

    public decimal ReplacementCost { get; set; }

    public string? Rating { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<FilmActor> FilmActors { get; set; } = new List<FilmActor>();

    public virtual ICollection<FilmCategory> FilmCategories { get; set; } = new List<FilmCategory>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual Language Language { get; set; } = null!;

    public virtual Language? OriginalLanguage { get; set; }
}
