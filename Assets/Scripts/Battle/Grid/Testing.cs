using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    
    private Grid grid;

    private void Start() {
        grid = new Grid(4,2, 10f, Color.white);
    }
    
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
    }
}
