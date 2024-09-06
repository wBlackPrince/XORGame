using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GraphConnectors{

    public static Vector2 [] positions = new Vector2[100]; //? позиции узлов
    public static GameObject [] lines = new GameObject[51]; //? линии
    public static int currentPosition = 0; //? текущая позиция точки в массиве positions

    private static float width = .3f;

    public static void AddPositions(Vector2 nodePos){
        positions[currentPosition] = nodePos;
        DrawLine(currentPosition - 1,currentPosition);
        currentPosition++;
    }


    private static void DrawLine(int nodeIdA, int nodeIdB){
        if (currentPosition % 2 == 0){
            return;
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
    }
    
}
