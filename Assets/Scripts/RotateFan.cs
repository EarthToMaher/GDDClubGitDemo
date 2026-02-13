using System;
using UnityEngine;

public class RotateFan : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.forward, 15f);
    }
}
