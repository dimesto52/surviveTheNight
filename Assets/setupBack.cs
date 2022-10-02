using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setupBack : MonoBehaviour
{
    SpriteRenderer render
    {
        get
        {
            return this.GetComponent<SpriteRenderer>();
        }
    }
    public backType type;

    // Start is called before the first frame update
    void Start()
    {
        render.size = new Vector2(Camera.main.orthographicSize * Camera.main.aspect, Camera.main.orthographicSize) * 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = (Camera.main.transform.position.x / (Camera.main.orthographicSize * Camera.main.aspect*2.0f));
        float y = (Camera.main.transform.position.y / (Camera.main.orthographicSize*2.0f));

        int X = (int)(x);
        int Y = (int)(y);

        x = x - X;
        y = y - Y;

        switch(type)
        {
            case backType.center:
                break;

            case backType.horisontal:
                    if (x > 0) X++;
                    if (x < 0) X--;
                    break;
            case backType.vertical:
                if (y > 0) Y++;
                if (y < 0) Y--;
                break;
            case backType.angle:
                if (x > 0) X++;
                if (x < 0) X--;
                if (y > 0) Y++;
                if (y < 0) Y--;
                break;
        }
        transform.position = new Vector3(X * (Camera.main.orthographicSize * Camera.main.aspect)*2, Y * (Camera.main.orthographicSize)*2, 1);
        //transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y,1);
    }
}
public enum backType
{
    center ,horisontal,vertical, angle
}
