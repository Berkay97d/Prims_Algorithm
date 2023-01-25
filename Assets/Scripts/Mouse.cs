using System;
using UnityEngine;


public class Mouse : MonoBehaviour
{
    public static Vector3 Position;

    private void Update()
    {
        Position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
