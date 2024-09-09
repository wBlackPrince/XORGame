using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour{
    
    [SerializeField] 
    Transform NandPrefab;

    public void GenerateNand()
    {
        ValvesController.valves[ValvesController.currentValve] = Instantiate(NandPrefab);
        ValvesController.currentValve++;
        ValvesController.valves[0].transform.Find("Square"); //TODO
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
