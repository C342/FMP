using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject
{
    public TileBase Tile;
    public Itemtype type;
    public ActionType actiontype;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Only gameplay")]

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum Itemtype
{
    Buildingblock,
    Tool
}

public enum ActionType
{
    Dig,
    Mine
}