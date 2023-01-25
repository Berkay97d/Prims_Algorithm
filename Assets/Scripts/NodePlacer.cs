using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NodePlacer : MonoBehaviour
{
    [SerializeField] private Node node;
    public static List<Node> AllNodes = new List<Node>();
    private static readonly int FirstLetterAsInt = Convert.ToInt32('A');
    
    private void OnMouseDown()
    {
        var obj = Instantiate(node, Mouse.Position, quaternion.identity);
        AllNodes.Add(obj);
        obj.letter = IndexToChar(AllNodes.IndexOf(obj));
    }

    
    private char IndexToChar(int index)
    {
        return Convert.ToChar(index + 65);
    }
    
}
