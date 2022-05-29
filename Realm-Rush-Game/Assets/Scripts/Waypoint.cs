using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
[SerializeField] bool isPlaceable;
[SerializeField] GameObject ballistaPrefab;
    void OnMouseDown() {
        if(isPlaceable)
        {
            Instantiate(ballistaPrefab, transform.position, Quaternion.identity);
            Debug.Log("Ballista instantiated at" + transform.name);
            isPlaceable = false;
        }
    }
}
