using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KoleksiyonYapilari : MonoBehaviour
{
    [SerializeField] int[] ornekDiziler2;
    [SerializeField] List<int> ornekList;
    //[SerializeField] Dictionary<int, string> ornekDictionary;

    int[] _ornekDiziler1;

    void Start()
    {
        _ornekDiziler1 = new int[5];
    }

    private void ListGiris()
    {
        // list yapilarimiz arrayler kadar performansli ama tam onlar kadar degil generic calisan yapilarimizdir
        //cunku arraylarin belli bir alani var esnekligi yok listin ise esnekligi var bu yuzden arrayler daha performanslidir
        //uzun yazim
        //List<int> numbers = new List<int>();

        //numbers.Add(10);
        //numbers.Add(20);
        //numbers.Add(5);
        //numbers.Add(25);
        //numbers.Add(55);

        //kisa yazimi
        List<int> numbers = new List<int>
        {
            10,
            20,
            5,
            25,
            55
        };

        Debug.Log(numbers[2]);

        for (int i = 0; i < numbers.Count; i++)
        {
            Debug.Log(numbers[i]);
        }
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }

    private void ArrayDizi()
    {
        //array(dizi) sadece int olmak zorunda degil butun yapilarimiz neredeyse dizi olabilir.
        //diziler bir yapinin icine birden fazla deger vermemizi ve saklamamizi saglar, her biri icin degisken olusturmak zorunda kalmayiz koleksiyon mantigi budur
        //int[] numbers = new int[6];

        //numbers[0] = 10;
        //numbers[1] = 20;
        //numbers[2] = 5;
        //numbers[3] = 25;
        //numbers[4] = 55;
        //numbers[5] = 60; //hatali giris cunku biz 5 tane actik ve 0 dan basladigimiz icin numbers[5] 6. olur ve hata aliriz

        //Debug.Log(numbers[1]);

        //1.kisa yazim
        //int[] numbers = new int[5] {10, 20, 5, 25, 55};

        //2.kisa yazim
        int[] numbers = {10, 20, 5, 25, 55};

        //for dongusu neyi verirsek onu calistirir yukarida dizi sayilarini arttirirsak for dongusunde de arttirmamiz degisiklik yapmamiz gerekir
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(numbers[i]);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }

        //foreach benden bir sayac istemez koleksiyon yapisi ister icinde ne kadar veri varsa o kadar calisir
        //foreach (int number in numbers)
        //{
        //    Debug.Log(number);
        //}
    }

    private void DictionaryGiris()
    {
        //Dictionary<string, string> ornekler1 = new Dictionary<string, string>();

        //ornekler1.Add("Telefon", "Phone");
        //ornekler1.Add("Ev", "Home");
        //ornekler1.Add("Bilgisayar", "Computer");
        //ornekler1.Add("Ornek1", "Computer");
        //ornekler1.Add("Bilgisayar", "Ornek2"); //bir dictionary collection yapisi icinde ayni anahtar degerinden iki tane olamaz hata verir ama birden fazla ayni value olabilir

        //foreach (var ornek in ornekler1)
        //{
        //    Debug.Log(ornek);
        //}

        //string value = ornekler1["Bilgisayar"];

        //Debug.Log(value);

        //string value = ornekler1.FirstOrDefault(x => x.Key == "Ornek1").Value;

        //Debug.Log(value);

        Dictionary<int, string> ornekler2 = new Dictionary<int, string>();

        ornekler2.Add(1, "Ornek 1");
        ornekler2.Add(2, "Ornek 2");
        ornekler2.Add(3, "Ornek 3");

        string value = ornekler2.FirstOrDefault(x => x.Key == 1).Value;

        Debug.Log(value);
    }

    private void QueueGiris()
    {
        Queue<string> days = new Queue<string>();

        days.Enqueue("Pazartesi");
        days.Enqueue("Sali");
        days.Enqueue("Carsamba");

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(days.Dequeue());
        }
    }
}
