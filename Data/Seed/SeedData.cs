using System.Text.Json;
using TestProject.Data.Models;
using TestProject.DTOs;
using Microsoft.EntityFrameworkCore;

namespace TestProject.Seed;

public static class SeedData
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public static async Task EnsureSeededAsync(TestProjectDbContext.Data db, IWebHostEnvironment env, CancellationToken ct = default)
    {
        await db.Database.MigrateAsync(ct);

        if (await db.Users.AnyAsync(ct))
        {
            return;
        }

        var path = Path.Combine(env.ContentRootPath, "Seed", "users.seed.json");
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Seed file not found: {path}");
        }

        var json = await File.ReadAllTextAsync(path, ct);

        var dtos = JsonSerializer.Deserialize<List<UserDTO>>(json, JsonOptions)
            ?? throw new InvalidOperationException("Failed to deserialize seed JSON.");

        var entities = dtos.Select(d => d.ToEntity()).ToList();
        db.Users.AddRange(entities);
        await db.SaveChangesAsync(ct);
    }
}