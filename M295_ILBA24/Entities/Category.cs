﻿using System;
using System.Collections.Generic;

namespace M295_ILBA24.Entities;

public partial class Category
{
    public byte CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<FilmCategory> FilmCategories { get; set; } = new List<FilmCategory>();
}
