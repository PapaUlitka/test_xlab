using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallStone : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
    public GameObject stone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction1 = (point1.position - transform.position).sqrMagnitude;
        float direction2 = (point2.position - transform.position).sqrMagnitude;
        float direction3 = (point3.position - transform.position).sqrMagnitude;
        float direction4 = (point4.position - transform.position).sqrMagnitude;
        float direction5 = (point5.position - transform.position).sqrMagnitude;

        if (direction1 < direction2 && direction1 < direction3 && direction1 < direction4 && direction1 < direction5)
        {
            SpawnStone(point1);
        }
        else if (direction2 < direction3 && direction2 < direction4 && direction2 < direction5)
        {
            SpawnStone(point2);
        }
        else if (direction3 < direction4 && direction3 < direction5)
        {
            SpawnStone(point3);
        }
        else if (direction4 < direction5)
        {
            SpawnStone(point4);
        }
        else SpawnStone(point5);
    }
    public void SpawnStone(Transform point)
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(stone, point.position, point.rotation);
        }
        
    }
}
