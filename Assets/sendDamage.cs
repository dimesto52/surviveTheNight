using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendDamage : MonoBehaviour
{
    public float damage = 1.0f;
    public GameObject particulTouch;
    public GameObject soundTouch;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        execute(collision.collider);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        execute(collision);
    }
    private void execute(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<mobLife>() != null)
        {
            collision.gameObject.SendMessage("takeDamageMob", damage, SendMessageOptions.DontRequireReceiver);


            GameObject pTouch = GameObject.Instantiate(particulTouch);
            pTouch.transform.position = collision.transform.position;

            float targetY = this.GetComponent<projectilMove>().moveDirection.y;
            float targetX = this.GetComponent<projectilMove>().moveDirection.x;

            float rot_z = Mathf.Atan2(targetY , targetX) * Mathf.Rad2Deg;
            pTouch.transform.rotation = Quaternion.Euler(-rot_z, 90f, -90);

            Debug.Log(rot_z);

            GameObject sTouch = GameObject.Instantiate(soundTouch);
            sTouch.transform.position = collision.transform.position;
        }
    }
}
