using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class compteur : MonoBehaviour
{
    public static compteur instance;

    TMP_Text txt;

    float timeElaps = 0;
    public int cycle = 0;

    RectTransform recttransform
    {
        get
        {
            return (RectTransform)transform;
        }
    }
    Vector2 baseSize = Vector2.zero;
    public float pulseAmont = 1.0f;
    public UnityEvent onCLockDown;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        txt = this.GetComponent<TMP_Text>();
        txt.text = "(0)10.000";
        baseSize = recttransform.sizeDelta;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            timeElaps += Time.deltaTime;
            if (timeElaps > 10)
            {
                timeElaps -= 10;
                cycle++;
                onCLockDown.Invoke();
            }

            txt.text = "(" + cycle +")"+ string.Format("{0:00.000}", (10 - timeElaps));

            float pulse = 0;
            pulse = (((10 - timeElaps) * 100) % 100);

            recttransform.sizeDelta = baseSize * (1 + pulse * pulseAmont);
        }
    }

    bool isOn = true;
    public void dead()
    {
        isOn = false;
    }
}
