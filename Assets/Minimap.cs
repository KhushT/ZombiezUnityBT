using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform PlayerArmature;

    void LateUpdate ()
    {
        Vector3 newPosition = PlayerArmature.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
