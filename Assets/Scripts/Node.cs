
using UnityEngine;

class Node: MonoBehaviour{
    public bool state = false;

    void Awake(){
        ChangeColor();
    }


    public void ChangeState(bool signal){
        state = signal;
        ChangeColor();
    }

    public void ChangeColor(){
        Renderer renderer = transform.GetComponent<Renderer>();
        Debug.Log(state);
        renderer.material.color = (state == true) ? (Color.green) : (Color.red);
    }

    private void OnMouseDown(){
        state = (state == true) ? (false) : (true); 
        ChangeColor();
    }
}

