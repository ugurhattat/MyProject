using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegerTipVeRefTipFark : MonoBehaviour
{
    void Start()
    {
        //referans tipler
        //string tipinde bir dizi values1 olusturduk ve bunun ram kaynak adresi ram201 olsun
        string[] values1 = { "Istanbul", "Ankara", "Izmir" };

        //string tipinde bir dizi values1 olusturduk ve bunun ram kaynak adresi ram202 olsun
        string[] values2 = { "Adana", "Bursa", "Diyarbakir" };

        values2 = values1; //burda biz artik ref degerlerini degil direk ram kaynak adreslerini atariz

        values1[0] = "Bodrum";

        //Debug.Log(values1[0]); //Bodrum
        //Debug.Log(values2[0]); //Bodrum
    }

    private void DegerTipler()
    {
        //deger tip
        int sayi1 = 10; //stack alanda int tipinde sayi1 degiskeni olusturuyor ve ram101
        int sayi2 = sayi1; //int tipinde sayi2 degiskeni olusturduk ve ram kaynak adresi ram102 ve ram102 icine ram kaynak adresine 10 degerini atadik

        sayi1++;

        //Debug.Log("Sayi1 =>" + sayi1); //"Sayi1 =>11"
        //Debug.Log("Sayi2 =>" + sayi2); //10
    }

}
