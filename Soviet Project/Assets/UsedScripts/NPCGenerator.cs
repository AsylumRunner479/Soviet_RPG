using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public Transform Grid;
    public Transform NPC;
    public NPCStats stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Generate()
    {
        Transform clone = Instantiate(NPC, Grid);
        
        clone.transform.SetParent(Grid.transform);
        
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
