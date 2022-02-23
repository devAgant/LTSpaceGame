using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grid {

    public event EventHandler<OnGridValueChangeEventArgs> OnGridValueChange;
    public class OnGridValueChangeEventArgs : EventArgs {
        public int x;
        public int y;        
    }

    private int width;
    private int height;
    private float cellSize;
    private Color color;
    private int[,] gridArray;
    private Vector3 originPosition;
    private TextMesh[,] debugTextArray;
    
    public Grid(int width, int height, float cellSize, Color color, Vector3 originPosition) {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        this.color = color;
        this.originPosition = originPosition;
        
        gridArray = new int[width, height];
        debugTextArray = new TextMesh[width, height];
        
        
        for (int x=0; x<gridArray.GetLength(0); x++) {
            for (int y=0; y<gridArray.GetLength(1); y++) {
                debugTextArray[x ,y] = UtilsClass.CreateWorldText(gridArray[x,y].ToString(), null, GetWorldPosition(x, y)  + new Vector3(cellSize, cellSize) * 0.5f, 20, Color.white, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), color, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), color, 100f);
            }
        }
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), color, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), color, 100f);
        
        SetValue(2, 1, 56);
    }
    
    public int GetWidth() {
        return width;
    }
    
    public int GetHeight() {
        return height;
    }
    
    public float GetCellSize() {
        return cellSize;
    }
    
    public Vector3 GetWorldPosition(int x, int y) {
        return new Vector3(x, y) * cellSize + originPosition;   
    }
    
    private void GetXY(Vector3 worldPosition, out int x, out int y) {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }
    
    public void SetValue(int x, int y, int value) {
        if (x >= 0 && y >= 0 && x < width && y < height) {
            gridArray[x, y] = value;
            if (OnGridValueChange != null) OnGridValueChange(this, new OnGridValueChangeEventArgs { x = x, y = y });
        }
    }
    
    public void SetValue(Vector3 worldPosition, int value) {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }
    
    public int GetValue(int x, int y) {
        if (x >= 0 && y >= 0 && x < width && y < height) {
            return gridArray[x, y];
        } else {
            return -1;
        }
        
    }
    
    public int GetValue(Vector3 worldPosition) {
        int x, y;
        GetXY(worldPosition, out x, out y);
        return GetValue(x, y);
    }
}
