using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Donguler : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 2 || i == 4)
            {
                continue; //eger i 2'ye esitse 2'yi pas gec onu yazdirma anlaminda
            }
            Debug.Log(i);
        }
    } 

    private void DoWhile()
    {
        //do while
        //while sart saglandigi sure boyunca calisir eger sartim hic saglanmazsa hic calismaz donguye girmez do while ise sart saglansin veya saglanmasin do while en az bir kere calisir

        while (false)
        {
            Debug.Log("sartimiz false oldugu icin calismaz");
        }

        // hizli do while yazimi
        do
        {
            Debug.Log("sartimiz sanlansin veya saglanmasin do while en az bir kere calisir");
        } while (false);
    }

    private void WhileDongumuz()
    {
        //Debug.Log("Bir islem oldu");
        //Debug.Log("Bir islem oldu");
        //Debug.Log("Bir islem oldu");
        //Debug.Log("Bir islem oldu");
        //Debug.Log("Bir islem oldu");
        //Debug.Log("Bir islem oldu");
        //Debug.Log("Bir islem oldu");

        //1. while
        //2. do while
        //3. for
        //4. foreach

        //int sayac = 0;
        int index = 0;

        // mantik index'in degeri 10'dan kucuk oldugu surece bu dongu calissin demis olduk sonuc bize true veya false if icinde oldugu gibi ama burda eger sartim true oldukca bu dongu calissin demis olduk
        while (index < 5)
        {
            Debug.Log("Bir islem oldu");
            index++; //indeximizi arttirmasi icin bu lazim yazmazsak sonsuz donguye gireriz
        }
    }

    private void ForDongumuz()
    {
        //i => indez

        //    sayac      sart   sayac artis
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Bir islem oldu");
        }

        ////for tab tab hizli yazim
        //for (int i = 0; i < length; i++)
        //{

        //}
    }

    private void ForeachMantigi()
    {
        //hizli foreach yazimi => ForEach tab tab
        //collection => bizden bir collection ister dizi list gibi ve o list yapisi icindeki deger kadar koleksiyon sayisi kadar degeri kadar calisir foreach her biri icin
        //foreach (var item in collection)
        //{

        //}
    }

    private void DonguIcindeBreak()
    {
        //break
        // o donguyu kir anlamindadir

        for (int i = 0; i < 10; i++)
        {
            if (i > 2)
            {
                break;
            }
            Debug.Log(i);
        }
    }
}
