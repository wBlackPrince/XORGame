using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinerTest : MonoBehaviour{
    [SerializeField]
    private Transform [] points;

    [SerializeField]
    private LinerController line;

    void Start(){
        line.SetUpLine(points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
