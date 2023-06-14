using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed;
    public float delay;

    public int facing = 1;

    void Start() {
        Invert();
    }

    void FixedUpdate() {
        transform.position = transform.position + new Vector3(speed * facing, 0, 0);
    }

    void Invert() {
        facing = -facing;

        Invoke("Invert", delay);
    }
}
