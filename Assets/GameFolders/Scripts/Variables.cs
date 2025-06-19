using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//pascal case ilk harf buyuk ve sonra gelen her kelimenin ilk harfi buyuk
public class Variables : MonoBehaviour
{
    //global alanimizdir
    //snake case yazim kurali once alt tire sonrası camel case ile aynı
    //global degisken global variable veya private field
    int _sayi = 10;
    int _sayiDegiskeni;
    void Start()
    {
        //local alan
        //camel case yazim kurali degiskenin ilk harfi kucuk sonraki gelen her kelimenin ilk harfi buyuk bu sekilde devam eder.
        //locak degiskenimiz
        int birinciSayideDegiskeni = 10;
        int sayi = 10;
        string deger1 = "bir seyler yazdik";



        string yeniVeri = deger1 + " eklendi"; //degiskeni degil degiskenin icindeki degeri kullaniyoruz

    }

    public void YeniBirMethod()
    {
        //local alan
    }

}
