using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendDomagePlayer : MonoBehaviour
{
    public float damage = 1.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<playerLife>() != null)
        {
            //collision.gameObject.GetComponent<playerLife>().takeDamagePlayer(damage);
            collision.gameObject.SendMessage("takeDamagePlayer", damage, SendMessageOptions.DontRequireReceiver);
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        collision.gameObject.SendMessage("takeDamagePlayer", damage, SendMessageOptions.DontRequireReceiver);
    }
}
