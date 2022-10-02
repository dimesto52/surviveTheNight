using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpCoin : MonoBehaviour
{
    public GameObject prefabsound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<playerLife>() != null)
        {
            GameObject goSound = GameObject.Instantiate(prefabsound);
            goSound.transform.position = transform.position;

            coinCompteur.instance.compte++;
            GameObject.Destroy(gameObject);
        }

    }

}
