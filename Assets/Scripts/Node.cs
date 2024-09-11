
using UnityEngine;

class Node: MonoBehaviour{
    public bool state = false;
    public bool isWire; //? есть ли соединение по проводу

    int NodeId = 0;

    public GameObject [] wiresArr = new GameObject[5]; //? массив проводов которые присоединены к этому узлу
    public Transform [] wiresArrExt = new Transform[5]; //? массив проводов которые присоединены к этому узлу

    public int currentWire = 0;


    void Awake(){
        ChangeColor();
        ValvesController.nodes[ValvesController.currentNode] = transform;
        ValvesController.currentNode++;
        NodeId = ValvesController.NodeId;
        ValvesController.NodeId++;
        
    }


    public void ChangeState(bool signal){
        state = signal;
        
        
        UpdateWires();
        
        //ChangeColor();
    }

    public void UpdateWires(){
        LineRenderer lineRenderer;
        
        for (int i = 0; i < wiresArr.Length; i++) {
            if (wiresArr[i] != null ) {
                lineRenderer = wiresArr[i].GetComponent<LineRenderer>();
                if (lineRenderer != null ) {
                    lineRenderer.material.color = state ? Color.green : Color.red;
                    wiresArrExt[i].GetComponent<Node>().state = state;
                    wiresArrExt[i].GetComponent<Renderer>().material.color = state ? Color.green : Color.red;
                } 
            } 
        }

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

