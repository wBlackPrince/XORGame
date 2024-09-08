using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateValves : MonoBehaviour{
    
    [SerializeField]
    Transform node;

    void Awake(){
        
    }


    private void OnMouseDown() {
        //GraphConnectors.nodes[GraphConnectors.currentNode] = Instantiate(node);
        //GraphConnectors.currentNode++;
    } //? если мы добавляем на сцену узел с помощью кнопки
    
    void Update(){
        
    }
}
