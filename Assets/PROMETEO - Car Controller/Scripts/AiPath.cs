using System;
using UnityEngine;

public class AiPath : MonoBehaviour
{
    public Transform[] paths;
    private Transform target;

    private int WayPointIndex = 0;
    public float speed = 70f;

    private void Start()
    {
        target = paths[WayPointIndex];
    }
    void Update()
    {
        Vector3 dir = target .position - transform.position;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        WayPointIndex++;
        target = paths[WayPointIndex];
    }
}
