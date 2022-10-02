using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinCompteur : MonoBehaviour
{
    public static coinCompteur instance;

    public int compte = 0;

    TMP_Text txt;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        txt = this.GetComponent<TMP_Text>();
        txt.text = "000";
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = string.Format("{0:000}", (compte));
    }
}
