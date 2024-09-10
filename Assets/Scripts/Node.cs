
using UnityEngine;

class Node: MonoBehaviour{
    public bool state = false;
    public bool isWire; //? есть ли соединение по проводу

    int NodeId;


    void Awake(){
        ChangeColor();
        ValvesController.nodes[ValvesController.currentNode] = transform;
        ValvesController.currentNode++;
        NodeId = ValvesController.NodeId;
        ValvesController.NodeId++;
    }


    public void ChangeState(bool signal){
        state = signal;
        ChangeColor();
    }

    public void ChangeColor(){
        Renderer renderer = transform.GetComponent<Renderer>();
        renderer.material.color = (state == true) ? (Color.green) : (Color.red);
    }

    private void OnMouseDown(){
        //state = (state == true) ? (false) : (true); 
        //ChangeColor();
        ValvesController.DrawingWires.Push(NodeId);
        ValvesController.BuildWire();
    }
}

