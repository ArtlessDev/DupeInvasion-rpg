using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    //this sets the initial dialogue
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col is BoxCollider2D)
        {
            //this should get/generate the values of the npc
            //then transition to combat scene
            var npc = PlayerData.GetRandomPlayerData("Monkey");
            Debug.Log(npc.GetPlayerStats());
        }
        if (col is CircleCollider2D)
        {
            Debug.Log("its a circle collider");
        }
    }

    //void onDis
}
