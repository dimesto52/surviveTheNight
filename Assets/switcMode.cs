using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class switcMode : MonoBehaviour
{
    public UnityEvent onRun;
    public UnityEvent onShoot;

    public Playmod mod;

    // Start is called before the first frame update
    void Start()
    {

        mod = Playmod.run;
        onRun.Invoke();
        this.SendMessage("setMod", mod);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void switching()
    {
        if (mod == Playmod.run)
        {
            mod = Playmod.shoot;
            onShoot.Invoke();
        }
        else
        {
            mod = Playmod.run;
            onRun.Invoke();
        }

        this.SendMessage("setMod", mod);

        /*
        foreach (MonoBehaviour mono in switchlist)
        {
            mono.enabled = !mono.enabled;
        }*/
    }
}
public enum Playmod
{
    run,
    shoot
}