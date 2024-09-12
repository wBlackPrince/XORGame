using UnityEngine;

public class NotGate : MonoBehaviour{
    Transform in1, output;

    void Awake(){
        in1 = transform.Find("in1");
        
        output = transform.Find("out");
        UpdateOutput();
    }


    public void UpdateOutput(){
        bool i1 = in1.GetComponent<Node>().state;
        in1.GetComponent<Node>().UpdateWires();
        output.GetComponent<Node>().ChangeState(!i1);
    }
    
    void Update(){
        UpdateOutput();
    }
}