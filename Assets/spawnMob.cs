using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMob : MonoBehaviour
{
    float timeElaps = 0;
    public GameObject prefabmob;
    public GameObject player;
    int cycle = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        timeElaps += Time.deltaTime;
        if (timeElaps > 0.5/ cycle)
        {
            timeElaps -= 1;
            spawn();
        }
    }
    public void cucleAdd()
    {
        cycle++;
    }
    public void spawn()
    {
        int side = Random.Range(0, 4);

        float x  = 0;
        float y  = 0;

        float X_size = Camera.main.orthographicSize * Camera.main.aspect;
        float Y_size = Camera.main.orthographicSize ;

        switch (side)
        {
            case 0:
                x = X_size;
                y = Random.Range(-Y_size, Y_size);
                break;
            case 1:
                y = Random.Range(-X_size, X_size);
                y = Y_size;
                break;
            case 2:
                x = -X_size;
                y = Random.Range(-Y_size, Y_size);
                break;
            case 3:
                y = Random.Range(-X_size, X_size);
                y = -Y_size;
                break;
        }

        if (x > 0) x++;
        if (x < 0) x--;
        if (y > 0) y++;
        if (y < 0) y--;

        Vector3 pos = new Vector3(Camera.main.transform.position.x + x, Camera.main.transform.position.y + y, 0);

        GameObject go = GameObject.Instantiate(prefabmob);
        go.GetComponent<movetoPlayer>().player = player;
        go.transform.position = pos;
    }
}
