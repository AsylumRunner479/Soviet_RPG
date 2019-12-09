﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStats : MonoBehaviour
{
    public RandomNumber random;
    public int Charisma, Compassion, Tenacity, Greed, Cunning, Intuition;
    public GameObject charisma, compassion, tenacity, greed, cunning, intuition;
    public GameObject StatDisplay;
    public GameObject NPCDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        CreateNPC();
        
    }
    public void CreateNPC()
    {
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
            Display = false;
        }
        if (Display == false)
        {
            StatDisplay.SetActive(false);
            NPCDisplay.SetActive(true);
            Display = true;
        }
    }
}
