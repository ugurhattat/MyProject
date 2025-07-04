using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeriTipleri:MonoBehaviour
{//baslangic scope

    //1. yazim kuralimiz codelar scopelar aras?na yazilir
    //2. methodlarinda ayni ac kapat scopelar? vardir ve method olustururken parantez normal parantez ac kapat yazmak zorundayiz bu bir yazim kuralidir. 
    //3. codelar ; ile biter
    //4. bu bir yorum satiridir c# bunu code olarak gormez bir gecerliligi yoktur tekli yorum satiridir
    //5. = atama operatorudur matematikteki gibi esitlik ifadesi anlam?na gelmez.

    /*
     * bu da coklu
     * yorum
     * satiridir
     * code karsiligi
     * yoktur
     */

    private void Start()
    {
        //method'u cagirirken parantez icine deger alsin ya da almasin parantez ac kapat yazilir bu bir yazim kuralidir.
        //Method1();
        //Method2();
        //Method3();
        //Method4();
        //Method5();
        Method6();
    }

    // yazim hatalarina syntax error denir
    public void Method1()
    {//baslangic scope

        //local alanimiz
        //int sayi1 = 10;
        //int sayi2 = sayi1;

        //short int 16'lik bir kucuk bir kutu int32 daha buyuk bir kutu ve kucuk kutumuzu buyuk kutumuzun icine koyduk ve hatasiz calisti
        //short sayi1 = 10; // short 16 bitlik alan kaplar
        //int sayi2 = sayi1; // sayi2 int tipinde ve 32 bitlik alan kaplar

        //short ornek = 50000;

        int sayi1 = 10;
        short sayi2 = Convert.ToInt16(sayi1);

        string yaziKarakteri = "biz bunun icine istedigimiz kadar yazi yazabiliriz";

        //yaziKarakteri = sayi1;
        //yaziKarakteri = sayi2;

        //Debug.Log(sayi1);
        Debug.Log(sayi2);
        Debug.Log(sayi2.GetType());
    }//kapanis scope

    private void Method2()
    {
        int sayi1 = 10;
        int sayi2 = 20;
        //aritmatik operatorler + - / *
        int sonuc = sayi1 + sayi2;

        //int tcKimlik = 12345678912;
        string tcKimlik = "12345678912";
        string telNo = "1234567891";

        //string yazi karakterlerinde birlestirir
        Debug.Log("Sonuc: " + sonuc);
        Debug.Log(string.Format("Sonuc: {0}", sonuc));
        Debug.Log($"Sonuc: {sonuc}");
    }

    private void Method3()
    {
        float sayi1 = 10.5f;
        float sayi2 = 20.9f;

        float sonuc = sayi1 + sayi2;

        Debug.Log($"Sonuc:{sonuc}");
    }

    private void Method4()
    {
        bool value1 = true;
        bool value2 = false;

        value1 = false; //deneme yaptik burada cevap degisecek mi diye degisti

        if(value1 == true)  //true ya da false yani bool deger alirlar
        {
            Debug.Log("value1 true oldu");
        }
        else
        {
            Debug.Log("value1 false oldu");
        }
    }

    private void Method5()
    {
        object value1 = 10; //int
        object value2 = "string veri"; //string
        object value3 = 55.99f; // float

        //int sayi1 = "string value";
        int value = 10;

        int sayi = (int)value1;
        string stringVeri = (string)value2;
    }

    private void Method6()
    {
        int sayi = 10;

        //    10 +
        //en uzun yazim
        //sayi = sayi + 20; // sonuc => 30
        //sayi -= 20; += -=

        // sayi = sayi+1;
        //sayi += 1;
        sayi++; //bir bir arttirir
        Debug.Log(sayi);

        sayi--; //bu bir bir azaltir
        Debug.Log(sayi);

        //string value = "unity";

        //value = value + ",";
        //value += ",";

        //Debug.Log(value);
    }

}//kapanis scope
