using UnityEngine;

public class NandGate : MonoBehaviour{
    [SerializeField]
    Transform inA, inB, outp; //? узлы на сцене

    Nand nan;

    void Awake(){
        nan = new Nand( inA, inB, outp);
        nan.SetInputs(true, true);
    }

    
    void Update(){
        
    }
}
