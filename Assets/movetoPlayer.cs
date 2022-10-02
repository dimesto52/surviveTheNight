using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoPlayer : MonoBehaviour
{

    public GameObject player;
    public float speed = 5;
    SpriteRenderer render
    {
        get
        {
            return this.GetComponent<SpriteRenderer>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        if (isOn)
        {

            Vector3 moveDirection = player.transform.position - transform.position;

            render.flipX = moveDirection.x > 0;

            transform.position += moveDirection.normalized * Time.fixedDeltaTime * speed;
        }
    }
    bool isOn = true;
    public void dead()
    {
        isOn = false;
    }
}
