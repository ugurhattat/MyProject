using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SartYapilari : MonoBehaviour
{
    [SerializeField] private int sayi; //private yazmasak bile kendini korumaya alir private acar
    [SerializeField] bool ternaryIfDegisken;
    [SerializeField] string gun;

    void Start()
    {
        /*
         * 1.if else
         * 2.switch case
         * 3.ternary if
         * 
         */

        //Switch case

        //if (gun == "Pazartesi")
        //{
        //    Debug.Log("Secili gun pazartesidir");
        //}
        //else if (gun == "Sali")
        //{
        //    Debug.Log("Secili gun salidir");
        //}
        //else if (gun == "Carsamba")
        //{
        //    Debug.Log("Secili gun carsambadir");
        //}
        //else
        //{
        //    Debug.Log("Hic bir sart saglanmamaktadir");
        //}

        //switch tab tab hizli switch case yazimidir
        switch (gun)
        {
            case "Pazartesi":
                //gun Pazartesi case'ine esit ise case ve break arasindaki codelari calistirir
                Debug.Log("Secili gun pazartesidir");
                break;
            case "Sali":
                Debug.Log("Secili gun salidir");
                break;
            case "Carsamba":
                Debug.Log("Secili gun carsambadir");
                break;
            default:
                Debug.Log("Hic bir sart saglanmamaktadir");
                break;
        }
    }

    private void IfElseGiris() 
    {
        //hizli yazim if else yazimi
        //if (true) // if tab tab
        //{

        //}
        //else // else tab tab
        //{

        //}

        //verilen sayi 10'dan kucukse true doner ve if scope icine girer
        if (sayi < 10) //parantez icine sart ister ve bu sart sonucu bize true ya da false yani bool tip doner
        {  //if baslangic scope
            Debug.Log("Verilen sayi 10'dan kucuktur");
        }  //if bitis scope
        else if (sayi > 10)
        {
            Debug.Log("Verilen sayi 10'dan buyuktur");
        }
        else
        {
            //else hicbir sart saglanmiyorsa beni calistir
            Debug.Log("hic bir sart saglanmiyorsa else calisir");
        }

        Debug.Log("Sart saglansin veya saglanmasin if else if else'ten sonra bu kisim calisir");
    }

    private void IfElseVeIliskiselOperatorler()
    {
        if (sayi < 10)
        {
            if (sayi > 5)
            {
                Debug.Log("Girilen sayi 10'dan kucuk ve 5'ten buyuktur");
            }
            else
            {
                Debug.Log("Girilen sayi 10'dan kucuk ve 5'ten kucuk veya 5'e esittir");
            }
        }

        //sayi 10'dan buyuk veya 10'a esit ise bize true don ve if sarti icinde ne isteniyorsa onu yap demis olduk

        if (sayi >= 10) // iliskisel operatorler => >=(buyuk esit mi?) <=(kucuk esit mi?) >(buyuk mu?) <(kucuk mu?) ==(esit mi?) !=(esit degilse) !(unlem olumsuzluk katar, not)
        {

        }
    }

    private void IfElseVeMantikOperatorleri()
    {
        //mantik operatorleri
        //ve &&(shift+6)
        //veya => ||(alt gr+"<,> tusu")

        //  true           true
        //if (sayi > 10 && sayi < 20)
        //{ //if baslangic scope
        //    Debug.Log("Girilen sayi 10'dan buyuk ve 20'den kucuktur");
        //}

        //veya mantigi ise iki sarttan sadece biri saglansa bile calisir
        //if (sayi <10 || sayi > 20)
        //{
        //    Debug.Log("Girilen sayi 10'dan kucuk veya 20'den buyuktur");
        //}
    }

    private void IfElseTernaryIf()
    {
        //int localDegisken;

        //normal if else
        //sart ()
        if (ternaryIfDegisken)
        {
            Debug.Log("True dondu Normal if else");
        }
        else
        {
            Debug.Log("False dondu Normal if else");
        }

        //ternary if denir   cok tercih edilmez okunmasi biraz daha guc oldugu icin
        //              sart                     true                     false
        Debug.Log(ternaryIfDegisken ? "True dondu Ternary If" : "False dondu Ternary If");
    }

}
