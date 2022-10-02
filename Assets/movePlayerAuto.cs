using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayerAuto : MonoBehaviour
{

    float timeElaps = 0;
    public Vector2 moveDirection = Vector2.zero;
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
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        timeElaps += Time.deltaTime;
        if (timeElaps > 0.25f)
        {
            timeElaps -= 0.25f;
            ChangeDirection();
        }

    }
    private void FixedUpdate()
    {
        if (isOn)
        {
            render.flipX = moveDirection.x > 0;
            transform.position += (Vector3)moveDirection * Time.fixedDeltaTime * speed;
        }


    }


    void ChangeDirection()
    {

        mobLife[] mobs = GameObject.FindObjectsOfType<mobLife>();
        Vector3 dir = Vector3.zero;
        foreach (mobLife mob in mobs)
        {
            if(Vector3.Distance(transform.position, mob.transform.position) < Camera.main.orthographicSize/2.0f)
            dir += (transform.position - mob.transform.position) * (1/ Vector3.Distance(transform.position, mob.transform.position));
        }
        Debug.DrawLine(transform.position, transform.position + dir.normalized,Color.red);

        moveDirection = dir.normalized;
        /*
        float angle = Random.Range(-Mathf.PI*2, Mathf.PI*2);
        float x = Mathf.Cos(angle);
        float y = Mathf.Sin(angle);

        moveDirection = new Vector2(x, y);
        */
    }
    bool isOn = false;
    public void setMod(Playmod mod)
    {
        isOn = (Playmod.shoot == mod);
    }
    public void dead()
    {
        isOn = false;
    }
}
