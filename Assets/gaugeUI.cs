using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gaugeUI : MonoBehaviour
{
    public float max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Update(float value)
    {
        this.GetComponent<Image>().fillAmount = value / max;
        this.GetComponent<Image>().SetAllDirty();
    }
}
