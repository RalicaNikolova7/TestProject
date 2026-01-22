using System;

namespace TestProject.DTOs;

public sealed record FollowDto(
    Guid Id,
    Guid FollowerId,
    string FollowerUsername,
    Guid FollowingId,
    string FollowingUsername,
    DateTime CreatedAt
);

