using System;

namespace TestProject.DTOs;

public sealed record UserDto(
    Guid Id,
    string Username,
    string Email,
    string Avatar,
    string Bio,
    DateTime CreatedAt
);