using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ValvesController{
    
    public static Transform [] valves = new Transform[100];

    public static Transform [] nodes = new Transform[100];

    public static GameObject [] wires = new GameObject[100];

    public static int currentValve,currentWire, start, end;

    public static int currentNode = 0;

    public static int NodeId = 0;

    public static Stack<int> DrawingWires = new Stack<int>(); //? провода которые нужно отрисовать, содержит порядковые номера узлов

    //public static Transform WireComponents

    public static Vector2 wireStart, wireEnd;

    public static float width = 0.3f;
    
    public static bool destroyEverything = false;

    public static void BuildWire(){
        
        if (DrawingWires.Count == 2){
            end = DrawingWires.Pop();
            start = DrawingWires.Pop();
            int positionNode = 0;
            int positionNodeStart = 0;
            for(int i = 0; i < nodes.Length; i++){
                if (i == start && i == end){
                    break;
                }
                if (i == start){
                    positionNode = i;
                    wireStart = (Vector2)nodes[i].position;
                }
                if (i == end){
                    positionNodeStart = i;
                    wireEnd = (Vector2)nodes[i].position;
                }
            }
            nodes[end].GetComponent<Node>().ChangeState(nodes[start].GetComponent<Node>().state);
            DrawLine(positionNode, positionNodeStart, wireStart, wireEnd, nodes[start].GetComponent<Renderer>().material.color);
            wireStart = Vector2.zero;
            wireEnd = Vector2.zero;
        }
        

    }

    public static void DrawLine(int positionNode, int positionNodeStart, Vector2 start, Vector2 end, Color color){
        GameObject line = new GameObject(); // создание объекта со своим именем
        wires[currentWire] = line;
        currentWire++;

        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();

        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));

        lineRenderer.material.color = color;

        lineRenderer.positionCount = 2; // число компонентов вроде точек

        lineRenderer.SetPosition(0, new Vector3(start.x - width/3.0f, start.y - width/3.0f, 0)); // 1 точка

        lineRenderer.SetPosition(1, new Vector3(end.x + width/3.0f, end.y + width/3.0f, 0)); // 2 точка

        lineRenderer.startWidth = width;

        lineRenderer.endWidth = width;

        int j = nodes[positionNode].GetComponent<Node>().currentWire;
        nodes[positionNode].GetComponent<Node>().wiresArr[j] = line;
        nodes[positionNode].GetComponent<Node>().wiresArrExt[j] = nodes[positionNodeStart];
        nodes[positionNode].GetComponent<Node>().currentWire++;
        
    }
    
    public static void ClearScene(){
        for(int i = 0; i < wires.Length; i++){
            GameObject.Destroy(wires[i]);
        }
        destroyEverything = true ;
        currentValve = 0;
        currentNode = 0;
        currentWire = 0;
        NodeId = 0;
        start = 0;
        end = 0;
    }

   
}