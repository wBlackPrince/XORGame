
using UnityEngine;

class Node{
    public Transform gate;
    bool state;

    public Node(Transform gate, bool signal = false){
        this.gate = gate;
        ChangeState(signal);
    }

    public bool GetState(){
        return state;
    }

    public void ChangeState(bool signal){
        state = signal;
        ChangeColor();
    }

    private void ChangeColor(){
        
        Renderer renderer = gate.GetComponent<Renderer>();
        renderer.material.color = (state) ? (Color.green) : (Color.red);
    }
}

