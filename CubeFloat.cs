using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour

{
    public float speed, tilt;
    public Vector3 target = new Vector3 (0, 2.2f, 3.88f);

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 2.2f)
            target.y = 2.2f;
        else if (transform.position == target && target.y == 2.2f)
            target.y = 1.0f;


        transform.Rotate(Vector3.up * tilt);
    }
}
