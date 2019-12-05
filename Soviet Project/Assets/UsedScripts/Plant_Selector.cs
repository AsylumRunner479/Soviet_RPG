using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant_Selector : MonoBehaviour
{
    //plants as GameObjects
   public GameObject Plant1;
   public GameObject Plant2;
   public GameObject Plant3;


   private Vector3 PlantPosition;
   private Vector3 Offscreenplant;

    private int CharacterInt = 1;

    //plan is too hit next character, 
    //current character is gameobject.set active false 
    //and next character is enabled


    private void Awake()
    {
        PlantPosition = Plant1.transform.position;
        Offscreenplant = Plant2.transform.position;
    }

    public void NextPlant()
    {
        switch (CharacterInt)
        {
            case 1:
                Plant1.gameObject.SetActive(false);
                Plant2.gameObject.SetActive(true);
                CharacterInt++;
                break;
            case 2:
                Plant2.gameObject.SetActive(false);
                Plant3.gameObject.SetActive(true);
                CharacterInt++;
                break;
            case 3:
                Plant3.gameObject.SetActive(false);
                Plant1.gameObject.SetActive(true);
                CharacterInt++;
                ResetPlantInt();
                break;
            default:
                ResetPlantInt();
                break;
        }
        

    }

    public void PreviousPlant()
    {
        switch (CharacterInt)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }

    }


    private void ResetPlantInt()
    {
        if (CharacterInt >= 4)
        {
            CharacterInt = 1;

        }

    }

}
