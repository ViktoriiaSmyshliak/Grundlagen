using System;

// Enable bitwise combination of enum values
[Flags]
public enum Genre
{
    // Explicit bit values required for flag combinations
    NonSpecified = 0,
    Action = 1,
    Thriller = 2,
    Crime = 4,
    Comedy = 8,
    Drama = 16,
    Documentation = 32
}