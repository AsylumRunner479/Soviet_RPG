using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCStats : MonoBehaviour
{
    public RandomNumber random;
    public int Charisma, Compassion, Tenacity, Greed, Cunning, Intuition, Hostility;
    public Slider charisma, compassion, tenacity, greed, cunning, intuition, hostility;
    public GameObject StatDisplay;
    public GameObject NPCDisplay;
    public Button Drink, Bribe, Promote, Rumour, Share, Execute;
    
    // Start is called before the first frame update
    void Start()
    {
        CreateNPC();
        
    }
    public void DrinkWith()
    {
        hostility.value -= 20;
        tenacity.value -= 20;
    }
    public void OfferBribe()
    {
        hostility.value -= Mathf.Clamp(greed.value / 5, 0, 20);

    }
    public void PromoteRank()
    {

    }
    public void SpreadRumour()
    {

    }
    public void ShareKnowledge()
    {

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
        random.Random10();
        Hostility = random.number100;
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
            compassion.value = Compassion;
            charisma.value = Charisma;
            tenacity.value = Tenacity;
            greed.value = Greed;
            cunning.value = Cunning;
            intuition.value = Intuition;
            hostility.value = Hostility;
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
