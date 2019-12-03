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


    private void Awake()
    {
        PlantPosition = Plant1.transform.position;
        Offscreenplant = Plant2.transform.position;
    }

    public void NextPlant()
    {
        

    }

    public void PreviousPlant()
    {


    }

}
