using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public GameObject NPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Generate()
    {
        Instantiate(NPC);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
