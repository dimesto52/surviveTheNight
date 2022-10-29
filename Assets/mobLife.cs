using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mobLife : MonoBehaviour
{
    public float life = 3.0f;
    public GameObject prefabSoundMDeath;
    public float chanceDrop = 0.5f;
    public GameObject drop;

    public GameObject particul;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void takeDamageMob(float value)
    {
        life -= value;
        if (life <= 0)
        {
            GameObject goSound = GameObject.Instantiate(prefabSoundMDeath);
            goSound.transform.position = transform.position;

            float isdrop = Random.Range(0.0f, 1.0f);
            if(isdrop <= chanceDrop)
            {
                GameObject godrop = GameObject.Instantiate(drop);
                godrop.transform.position = transform.position;

                GameObject p = GameObject.Instantiate(particul);
                p.transform.position = transform.position;
            }


            GameObject.Destroy(this.gameObject);
        }
    }
}
