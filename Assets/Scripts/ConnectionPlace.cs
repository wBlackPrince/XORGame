using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionPlace : MonoBehaviour{
    private void OnMouseDown(){
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        WireBuilder.AddPosition(mousePos, this.gameObject);
        
    }
}
