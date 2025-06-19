using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MethodGiris : MonoBehaviour


{
    [SerializeField] Text text;
    [SerializeField] Text textRef;
    
    // Start is called before the first frame update
    private void Start()
    {

        int sayi1;  //ram kaynak adresi ram101 icinde 50 degerini tasir
        int sayi2 = 60;

        Method7(out sayi1, sayi2);

        textRef.text = sayi1.ToString();

        //int sayi1 = 50;  //ram kaynak adresi ram101 icinde 50 degerini tasir
        //int sayi2 = 60;  

        //Method6(ref sayi1, sayi2);

        //textRef.text = sayi1.ToString();

        //Method5(44, 11, 22);
        //Method5(10, 20, 50, 90, 77, 33, 44, 11, 22);

        //Method4(20,30);

        //Method3();
        //Method3(10,40,5);

        //int result = Method2();

        //result += 10;

        //text.text = result.ToString();
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    // bu method parametre almayan ve deger dondurmeyen bir method'tur
    private void Method1()
    {
        int sayi1 = 30;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;

        text.text = sonuc.ToString();
    }

    //bu method parametre almayan ve int tipinde deger donduren bir method'tur
    private int Method2()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;

        return sonuc;
    }

    void Method3()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        int sonuc = sayi1 + sayi2;

        text.text = sonuc.ToString();
        Debug.Log($"{sonuc}");
    }

    void Method3(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;

        text.text = sonuc.ToString();
    }

    void Method3(int sayi1, int sayi2, int sayi3)
    {
        int sonuc = sayi1+ sayi2 + sayi3;

        text.text = sonuc.ToString();
        Debug.Log($"Method3overload3 {sonuc}");
    }

    void Method4(int sayi1 = 10,int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;

        text.text = sonuc.ToString() ;
    }

    void Method5(params int[] numbers)
    {
        int sonuc = 0;

        //foreach (int number in numbers)
        //{
        //    //sonuc = sonuc + number; alttakinin uzun yolu
        //    sonuc += number;
        //}

        sonuc = numbers.Sum();

        text.text = sonuc.ToString();
    }

    //                 50          60
    void Method6(ref int sayi1, int sayi2)
    {
        sayi1 = 10;  //ref keyword'u sayesinde burasi direk ram kaynak adresini alir yani ram101 ve iki degisken ayni ram kaynak adresinden beslendigi icin birinde olan degisiklik hepsinde olur

        int sonuc = sayi1 + sayi2;  // 10 + 60

        text.text = sonuc.ToString();  // 70
    }

    void Method7(out int sayi1, int sayi2)
    {
        sayi1 = 10;  //ref keyword'u sayesinde burasi direk ram kaynak adresini alir yani ram101 ve iki degisken ayni ram kaynak adresinden beslendigi icin birinde olan degisiklik hepsinde olur

        int sonuc = sayi1 + sayi2;  // 10 + 60

        text.text = sonuc.ToString();  // 70
    }
}
