using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBuilder {
    private static Vector2 [] positions = new Vector2[100]; //? позиции соединяющих узлов

    public static GameObject [] lines = new GameObject[51]; //? линии

    public static GameObject [] nodes = new GameObject[100]; //? сами соединительные узлы

    public static int currentPosition = 0;

     private static float width = .3f;

    public static void AddPosition(Vector2 mousePos, GameObject newNode){
        positions[currentPosition] = mousePos;
        nodes[currentPosition] = newNode;
        DrawLine(currentPosition - 1, currentPosition);
        currentPosition++;
    }


    private static void DrawLine(int nodeIdA, int nodeIdB){
        if (currentPosition % 2 == 0){
            return;
        }
        else{
            if (   Mathf.Abs(positions[currentPosition].x - positions[currentPosition - 1].x) <= 0.5f   &&
                Mathf.Abs(positions[currentPosition].y - positions[currentPosition - 1].y) <= 0.5f  ){
                    return;
                }
        }

        GameObject line = lines[currentPosition - 1] = new GameObject();

        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();

        //lineRenderer.material = new Material(Shader.Find("Unlit/Color"));

        //lineRenderer.material.color = colour;

        lineRenderer.positionCount = 2; // число компонентов вроде точек

        lineRenderer.SetPosition(0, new Vector3(positions[nodeIdA].x - width/3.0f, positions[nodeIdA].y - width/3.0f, 0f)); // 1 точка

        lineRenderer.SetPosition(1, new Vector3(positions[nodeIdB].x + width/3.0f, positions[nodeIdB].y + width/3.0f, 0f)); // 2 точка

        lineRenderer.startWidth = width;

        lineRenderer.endWidth = width;

        //? изменяем следующий узел
        nodes[currentPosition].GetComponent<Renderer>().material.color = nodes[currentPosition - 1].GetComponent<Renderer>().material.color;
        //nodes[currentPosition]
    }

    private static void DeleteLine(int pos){
        GameObject.Destroy(lines[pos], 2);
    } //TODO
    
}
