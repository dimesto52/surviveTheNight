using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilMove : MonoBehaviour
{
    public Vector2 moveDirection = Vector2.zero;
    public float speed = 5;

    private void FixedUpdate()
    {
        transform.position += (Vector3)moveDirection * Time.fixedDeltaTime * speed;
    }

}
