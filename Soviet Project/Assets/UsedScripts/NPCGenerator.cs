using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public GameObject Grid;
    public GameObject NPC;
    public NPCStats stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Generate()
    {
        Instantiate(NPC);
       
        NPC.transform.SetParent(Grid.transform);
        stats.CreateNPC();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
