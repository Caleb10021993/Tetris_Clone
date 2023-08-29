using UnityEngine.Tilemaps;
using UnityEngine;
using UnityEditor.U2D.Aseprite;

public enum Tetromino
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z,
}
[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells {get; private set; }

    public void Initilize()
    {
        this.cells = Data.Cells[this.tetromino];
    }
}
