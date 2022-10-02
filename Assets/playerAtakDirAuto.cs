using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAtakDirAuto : MonoBehaviour
{
    float timeElaps = 0;

    Vector2 dir = Vector2.zero;
    public GameObject prefabFojectil;
    public GameObject prefabsounShoot;

    // Start is called before the first frame update
    void Update()
    {
        if (isOn)
        {
            timeElaps += Time.deltaTime;
            if (timeElaps > 1)
            {
                timeElaps -= 1;
                ChangeDirection();
                useWeapon();
            }
        }
    }
    public void useWeapon()
    {
        GameObject go = GameObject.Instantiate(prefabFojectil);
        go.transform.position = transform.position;
        go.GetComponent<projectilMove>().moveDirection = dir;
        GameObject goSound = GameObject.Instantiate(prefabsounShoot);
        goSound.transform.position = transform.position;
    }

    void ChangeDirection()
    {
        float angle = Random.Range(-Mathf.PI * 2, Mathf.PI * 2);
        float x = Mathf.Cos(angle);
        float y = Mathf.Sin(angle);

        dir = new Vector2(x, y);
    }
    bool isOn = false;
    public void setMod(Playmod mod)
    {
        isOn = (Playmod.run == mod);
    }
    public void dead()
    {
        isOn = false;
    }
}
