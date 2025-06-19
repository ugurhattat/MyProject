using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Text localText;
    [SerializeField] Text globalText;

    int _sayi = 0;

    public void LocalArttir()
    {
        int sayi = 0;

        //sayi = sayi + 1;
        //sayi += 1;
        sayi++;

        localText.text = sayi.ToString();
    }

    public void GlobalArttir()
    {
        _sayi++;

        globalText.text = _sayi.ToString();
    }
}
