using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTimed : MonoBehaviour
{

    public float timed = 0;
    public float timeEnd = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timed < timeEnd)
        {
            timed += Time.deltaTime;


            if(timeEnd < timed)
                GameObject.Destroy(this.gameObject);
        }
        
    }
}
