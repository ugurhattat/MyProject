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
        Method1();
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

    }

}//kapanis scope
