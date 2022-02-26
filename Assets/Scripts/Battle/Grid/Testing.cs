using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    
    private Grid grid;

    private void Start() {
        grid = new Grid(20,10, 10f, Vector3.zero);
    }
    
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
            int value = grid.GetValue(position);
            grid.SetValue(position, value + 5);
        }
        
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
