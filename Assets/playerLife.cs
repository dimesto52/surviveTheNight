using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerLife : MonoBehaviour
{
    public float life = 3.0f;
    public UnityEvent onDead;
    public UnityEvent<float> onUpdateDamage;

    // Start is called before the first frame update

    public void takeDamagePlayer(float value)
    {
        life -= value;
        //Debug.Log(life);
        if (life <= 0)
        {
            onDead.Invoke();

            this.SendMessage("dead", SendMessageOptions.DontRequireReceiver);

            GameObject.FindObjectOfType<compteur>().dead();

            movetoPlayer[] mobs = GameObject.FindObjectsOfType<movetoPlayer>();
            foreach (movetoPlayer mob in mobs)
            {
                mob.dead();
            }
        }
            onUpdateDamage.Invoke(life);
    }
}
