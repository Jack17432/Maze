using UnityEngine;

public enum MazeDirection
{
    North,
    East,
    South,
    West
}

public static class MazeDirections
{
    public const int Count = 4;

    private static readonly IntVector2[] Vectors =
    {
        new IntVector2(0, 1),
        new IntVector2(1, 0),
        new IntVector2(0, -1),
        new IntVector2(-1, 0)
    };

    private static readonly MazeDirection[] Opposites =
    {
        MazeDirection.South,
        MazeDirection.West,
        MazeDirection.North,
        MazeDirection.East
    };

    private static readonly Quaternion[] Rotations =
    {
        Quaternion.identity,
        Quaternion.Euler(0f, 90f, 0f),
        Quaternion.Euler(0f, 180f, 0f),
        Quaternion.Euler(0f, 270f, 0f)
    }; 

    public static MazeDirection RandomValue => (MazeDirection)Random.Range(0, Count);
    public static IntVector2 ToIntVector2(this MazeDirection direction) => Vectors[(int)direction];
    public static MazeDirection GetOpposite(this MazeDirection direction) => Opposites[(int)direction];
    public static Quaternion ToRotation(this MazeDirection direction) => Rotations[(int)direction];
}