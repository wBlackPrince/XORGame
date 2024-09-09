using UnityEngine;

public class NandGate : MonoBehaviour{
    Transform in1, in2, output;

    void Awake(){
        in1 = transform.Find("in1");
        in2 = transform.Find("in2");
        output = transform.Find("out");
        UpdateOutput();
    }


    public void UpdateOutput(){
        bool i1 = in1.GetComponent<Node>().state;
        bool i2 = in2.GetComponent<Node>().state;
        output.GetComponent<Node>().ChangeState(!(i1 && i2));
    }
    
    void Update(){
        UpdateOutput();
    }
}
