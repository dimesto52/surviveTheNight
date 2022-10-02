using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendDamage : MonoBehaviour
{
    public float damage = 1.0f;
    public GameObject particul;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SendMessage("takeDamageMob", damage, SendMessageOptions.DontRequireReceiver);
        GameObject p = GameObject.Instantiate(particul);
        p.transform.position = collision.contacts[0].point;
        GameObject.Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<mobLife>() != null)
        {
            collision.gameObject.SendMessage("takeDamageMob", damage, SendMessageOptions.DontRequireReceiver);
            GameObject p = GameObject.Instantiate(particul);
            p.transform.position = collision.transform.position;
        }
    }
}
