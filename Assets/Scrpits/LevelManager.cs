using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
   
   public GameObject CurrentCheckpoint;
   
    void Start()
    {
        CurrentCheckpoint = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void RespawnPlayer(){

        FindObjectOfType<PlayerController>().transform.position = CurrentCheckpoint.transform.position;
    }



}
