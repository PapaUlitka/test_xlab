using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCloud : MonoBehaviour
{
    public Transform[] points;
    public int currentTargetIndex = 0;
    public float speed = 5f;
    private bool isMove = false;
    public ParticleSystem rain;
    // Start is called before the first frame update
    void Start()
    {
        rain = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !isMove)
        {
            isMove = true;
            currentTargetIndex = (currentTargetIndex + 1) % points.Length;
            rain.Stop();
        }
        if (isMove && points.Length > 0)
        {
            
            Transform target = points[currentTargetIndex];
            Vector3 direction = target.position - transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (direction.magnitude < 0.01f)
            {
                isMove = false;
                rain.Play();
            }
        }
        
    }
}
