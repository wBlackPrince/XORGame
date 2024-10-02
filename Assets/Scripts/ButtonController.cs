using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour{
    
    [SerializeField] 
    Transform NandPrefab;

    [SerializeField] 
    Transform OrPrefab;

    [SerializeField] 
    Transform AndPrefab;

    [SerializeField] 
    Transform NorPrefab;

    [SerializeField] 
    Transform NotPrefab;

    [SerializeField] 
    Transform NodePrefab;

    [SerializeField] 
    Transform BigAndPrefab;


    [SerializeField] 
    Transform BigOrPrefab;


    public void GenerateNand(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(NandPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateOr(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(OrPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateAnd(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(AndPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateNor(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(NorPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateNot(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(NotPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateNode(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(NodePrefab);
        ValvesController.currentValve++;
    }

    public void GenerateBigAnd(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(BigAndPrefab);
        ValvesController.currentValve++;
    }

    public void GenerateBigOr(){
        ValvesController.valves[ValvesController.currentValve] = Instantiate(BigOrPrefab);
        ValvesController.currentValve++;
    }


    public void RemoveScene(){
        ValvesController.ClearScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
