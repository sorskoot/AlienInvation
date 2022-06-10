using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileTypes
{
    Grass,
    City,
    Rock,
}


public class TileConfig : ScriptableObject
{
    public TileTypes connectTop;
    public TileTypes connectBottom;
    public TileTypes connectLeft;
    public TileTypes connectRight;
}

