using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    void Start()
    {
        StartCoroutine(PrintWaypointName());
    }

    IEnumerator PrintWaypointName()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;

            yield return new WaitForSeconds(1f);
        }
    }
}
