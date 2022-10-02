using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerAtakDir : MonoBehaviour
{
    float timeElaps = 0;

    Vector2 dir = Vector2.zero;
    public GameObject prefabFojectil;
    public GameObject prefabsounShoot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn)
        if (dir != Vector2.zero)
        {
            timeElaps += Time.deltaTime;
            if (timeElaps > 1)
            {
                timeElaps -= 1;
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

    public void onMovePointer(InputAction.CallbackContext context)
    {
        Vector2 pointerPos = context.ReadValue<Vector2>();
        Vector2 ScreenSize = new Vector2(Screen.width, Screen.height);
        dir = (pointerPos - ScreenSize/2.0f).normalized;
    }
    bool isOn = false;
    public void setMod(Playmod mod)
    {
        isOn = (Playmod.shoot == mod);
    }
    public void dead()
    {
        isOn = false;
    }
}
