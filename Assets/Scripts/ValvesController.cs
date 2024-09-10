using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ValvesController{
    
    public static Transform [] valves = new Transform[100];

    public static Transform [] nodes = new Transform[100];
    public static int currentValve, start, end;

    public static int currentNode = 0;

    public static int NodeId = 0;

    public static Stack<int> DrawingWires = new Stack<int>(); //? провода которые нужно отрисовать, содержит порядковые номера узлов


    public static Vector2 wireStart, wireEnd;

    public static float width = 0.3f;


    public static void BuildWire(){
        
        if (DrawingWires.Count == 2){
            end = DrawingWires.Pop();
            start = DrawingWires.Pop();
            for(int i = 0; i < nodes.Length; i++){
                if (i == start && i == end){
                    break;
                }
                if (i == start){
                    wireStart = (Vector2)nodes[i].position;
                }
                if (i == end){
                    wireEnd = (Vector2)nodes[i].position;
                }
            }
            nodes[end].GetComponent<Node>().ChangeState(nodes[start].GetComponent<Node>().state);
            DrawLine(wireStart, wireEnd, nodes[start].GetComponent<Renderer>().material.color);
            wireStart = Vector2.zero;
            wireEnd = Vector2.zero;
        }
        

    }

    public static void DrawLine(Vector2 start, Vector2 end, Color color){
        GameObject line = new GameObject(); // создание объекта со своим именем

        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();

        //lineRenderer.material = new Material(Shader.Find("Unlit/Color"));

        lineRenderer.material.color = color;

        lineRenderer.positionCount = 2; // число компонентов вроде точек

        lineRenderer.SetPosition(0, new Vector3(start.x - width/3.0f, start.y - width/3.0f, 0)); // 1 точка

        lineRenderer.SetPosition(1, new Vector3(end.x + width/3.0f, end.y + width/3.0f, 0)); // 2 точка

        lineRenderer.startWidth = width;

        lineRenderer.endWidth = width;
    }
    

   
}