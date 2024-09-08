using UnityEngine;


  //? если добавить этот класс объекту на сцене его можно будет передвигать (скорее всего пока будет использоваться только для узлов)
public class Draggable : MonoBehaviour {
    Vector2 difference = Vector2.zero;

    private void OnMouseDown() {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        difference = mousePos - (Vector2)transform.position;
    }

    private void OnMouseDrag() {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    void Update(){
        
    }
}