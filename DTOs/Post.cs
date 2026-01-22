using System;

namespace TestProject.DTOs;

public sealed record PostDto(
    Guid Id,
    string Content,
    DateTime CreatedAt,
    Guid UserId,
    string Username
);
