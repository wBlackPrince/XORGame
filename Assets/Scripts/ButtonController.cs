using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour{
    
    [SerializeField] 
    Transform NandPrefab;

    [SerializeField] 
    Transform OrPrefab;

    public void GenerateNand(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(NandPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateOr(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(OrPrefab);
        ValvesController.currentValve++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
