﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCStats : MonoBehaviour
{
    public RandomNumber random;
    public int Charisma, Compassion, Tenacity, Greed, Cunning, Intuition, Hostility;
    public GameObject charisma, compassion, tenacity, greed, cunning, intuition, hostility;
    public Text Name, displayname;
    public string[] Advantage, displayadvantage;
    //public Text Advantage1, displayadvantage1;
    //public Text Advantage2, displayadvantage2;
    public GameObject StatDisplay;
    public GameObject NPCDisplay;
    public Button Drink, Bribe, Promote, Rumour, Share, Execute;
    public GameObject self;
    private string[] names = new string[] { "Albert", "Bogdan", "Dmitry", "Eduard", "Fedir", "German", "Igor", "Julij", "Konstantin", "Lavrentii", "Maxim", "Naum", "Osip", "Peter", "Roman", "Tit", "Vlad", "Yuri", "Vyacheslav", "Goga", "Alexei", "Viktor", "Misha", "Innokentiy", "Stefan", "Stanislav", "Foma", "Ruslan", "Taras", "Mitrofan", "Erik", "Spartak", "Modest", "Garry", "Nikita", "Boris", "Dobrushin", "Trofim", "Anton", "Mikhail", "Abram", "Gedeon", "Dorofey", "Savin", "Isodor", "Leonid", "Gleb", "Valentin", "David", "Daniil", "Ippolit", "Kirill", "Lazar", "Filipp", "Marlen", "Nestor", "Robert", "Arkady", "Pasha", "Valeriy", "Rolan", "Makariy", "Yulian", "Gennady", "Sergei", "Fanasiy", "Khan", "Semyon", "Yakov", "Rurik", "Faddei", "Yefim", "Nikolay", "Sasha", "Vladimir", "Alexander", "Stas", "Ipatiy", "Kolmogorov", "Vitaliy", "Vladislav", "Artyom", "Yana", "Olga", "Fedor", "Vasily", "Ivanovich", "Leo", "Pierre", "Anna", "Natasha", "Andrei" };
    private string[] advantage = new string[] { "Charming", "Nice", "Tough", "Corrupt", "Smart", "Perceptive", "Hateful", "Ugly", "Arsehole", "Wimp", "Honest", "Moron", "Naive", "Lovely" };
    private string[] lastNames = new string[] { "Isayev", "Tikhonov", "Chapayev", "Petka", "Anka", "Furmanov", "Budyonny", "Caesar", "Rzhevsky", "Tolstoy", "Bezukhov", "Blonsky", "Romanov", "Pavlovna", "Rostova", "Bolkonsky", "Kuragin", "Vidor", "Bondarchuk", "Levi", "Livinov", "Solomin", "Aksyonov", "Kalashnikov", "Gorbachev", "Smirnov", "Chernov", "Putin", "Brezhnev", "Pushkin", "Lipatov", "Khruschev", "Yeltsin", "Medvedev", "Anatolievych", "Vladimirovich" };
    public string GetRandomName()
    {
        return names[Random.Range(0, names.Length)];
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateNPC();
        Debug.Log(GetRandomName());
        
    }
    public void Fire()
        {
        Destroy(self);
        DayHandler.CurActionPoints -= 1;
    }
    public void DrinkWith()
    {
        hostility.GetComponent<Slider>().value -= 20;
        tenacity.GetComponent<Slider>().value -= 20;
        DayHandler.CurActionPoints -= 1;
    }
    public void OfferBribe()
    {
        hostility.GetComponent<Slider>().value -= Mathf.Clamp(greed.GetComponent<Slider>().value / 5, 0, 20);
        DayHandler.CurActionPoints -= 1;
    }
    public void PromoteRank()
    {
        DayHandler.CurActionPoints -= 1;
    }
    public void SpreadRumour()
    {
        DayHandler.CurActionPoints -= 1;
    }
    public void ShareKnowledge()
    {
        DayHandler.CurActionPoints -= 1;
    }
    public void CreateNPC()
    {
        //charisma = GameObject.FindGameObjectWithTag("charisma");
        random.Random10();
        Charisma = random.number100;
        random.Random10();
        Compassion = random.number100;
        random.Random10();
        Tenacity = random.number100;
        random.Random10();
        Greed = random.number100;
        random.Random10();
        Cunning = random.number100;
        random.Random10();
        Intuition = random.number100;
        random.Random10();
        Hostility = random.number100;
        Name.text = names[Random.Range(0, names.Length)] + " "  + lastNames[Random.Range(0, lastNames.Length)];
        compassion = GameObject.FindGameObjectWithTag("compassion");
        charisma = GameObject.FindGameObjectWithTag("charisma");
        tenacity = GameObject.FindGameObjectWithTag("tenacity");
        greed = GameObject.FindGameObjectWithTag("greed");
        cunning = GameObject.FindGameObjectWithTag("cunning");
        intuition = GameObject.FindGameObjectWithTag("intuition");
        hostility = GameObject.FindGameObjectWithTag("hostility");
        

        for (int i = 0; i < 3; i++)
        {
            Advantage[i] = advantage[Random.Range(0, advantage.Length)];
            Debug.Log(Advantage[i]);
            if (Advantage[i] == "Charming")
            {
                Charisma += 20;
            }
            else if (Advantage[i] == "Ugly")
            {
                Charisma -= 20;
            }
            else if (Advantage[i] == "Nice")
            {
                Compassion += 20;
            }
            else if (Advantage[i] == "Arsehole")
            {
                Compassion -= 20;
            }
            else if (Advantage[i] == "Tough")
            {
                Tenacity += 20;
            }
            else if (Advantage[i] == "Wimp")
            {
                Tenacity -= 20;
            }
            else if (Advantage[i] == "Corrupt")
            {
                Greed += 20;
            }
            else if (Advantage[i] == "Honest")
            {
                Greed -= 20;
            }
            else if (Advantage[i] == "Smart")
            {
                Cunning += 20;
            }
            else if (Advantage[i] == "Moron")
            {
                Cunning -= 20;
            }
            else if (Advantage[i] == "Perceptive")
            {
                Intuition += 20;
            }
            else if (Advantage[i] == "Naive")
            {
                Intuition -= 20;
            }
            else if (Advantage[i] == "Hateful")
            {
                Hostility += 20;
            }
            else if (Advantage[i] == "Lovely")
            {
                Hostility -= 20;
            }
            else
            {

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayStats(bool Display)
    {
        if (Display == true)
        {
            StatDisplay.SetActive(true);
            NPCDisplay.SetActive(false);
            charisma.GetComponent<Slider>().value = Charisma;
            tenacity.GetComponent<Slider>().value = Tenacity;
            greed.GetComponent<Slider>().value = Greed;
            cunning.GetComponent<Slider>().value = Cunning;
            intuition.GetComponent<Slider>().value = Intuition;
            hostility.GetComponent<Slider>().value = Hostility;
            displayname.text = Name.text;
            //displayadvantage.text = Advantage.text;
            //displayadvantage1.text = Advantage1.text;
            //displayadvantage2.text = Advantage2.text;
        }
        if (Display == false)
        {
            StatDisplay.SetActive(false);
            NPCDisplay.SetActive(true);
            
        }
    }
    public void DisplayInteract(bool Interact)
    {
        if (Interact == true)
        {
            StatDisplay.SetActive(false);
            NPCDisplay.SetActive(false);
            
        }
        if (Interact == false)
        {
            StatDisplay.SetActive(false);
            NPCDisplay.SetActive(false);

        }
    }
}
