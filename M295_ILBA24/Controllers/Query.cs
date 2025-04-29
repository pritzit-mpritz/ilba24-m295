using HotChocolate;
using HotChocolate.Data;
using M295_ILBA24.Context;
using M295_ILBA24.Entities;
using Microsoft.EntityFrameworkCore;

namespace M295_ILBA24.Controllers;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Film> GetFilms([Service] IDbContextFactory<SakilaDbContext> dbContextFactory)
    {
        var dbContext = dbContextFactory.CreateDbContext();
        return dbContext.Films;
    }
}