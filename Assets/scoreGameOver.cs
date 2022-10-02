using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreGameOver : MonoBehaviour
{
    public TMP_Text coin;
    public TMP_Text cycle;
    public TMP_Text total;
    // Start is called before the first frame update
    void Start()
    {
        coin.text  = string.Format("{0:000}", (coinCompteur.instance.compte));
        cycle.text = string.Format("{0:000}", (compteur.instance.cycle * 10));
        total.text = string.Format("{0:000}", (coinCompteur.instance.compte) + (compteur.instance.cycle * 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
