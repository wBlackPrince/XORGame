using UnityEngine;

public class OrGate : MonoBehaviour{
    Transform in1, in2, output;

    void Awake(){
        in1 = transform.Find("in1");
       
        in2 = transform.Find("in2");
        
        output = transform.Find("out");
        ValvesController.destroyEverything = false;
        UpdateOutput();
    }


    public void UpdateOutput(){
        bool i1 = in1.GetComponent<Node>().state;
        bool i2 = in2.GetComponent<Node>().state;
        in1.GetComponent<Node>().UpdateWires();
        in2.GetComponent<Node>().UpdateWires();
        output.GetComponent<Node>().ChangeState((i1 || i2));
    }
    
    void Update(){
        UpdateOutput();
        if(ValvesController.destroyEverything == true){
            GameObject.Destroy(gameObject);
        }
    }
}