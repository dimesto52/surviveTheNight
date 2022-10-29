using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uiTestLive : MonoBehaviour
{
    TMP_Text txt;
    // Start is called before the first frame update
    void Start()
    {

        txt = this.GetComponent<TMP_Text>();
    }
    void Update()
    {
    }

    // Update is called once per frame
    public void Update(float value)
    {
        Debug.Log(value);
        txt.text = (value).ToString();
    }
}
