using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldNpc : MonoBehaviour
{
    public Transform player;
    public Transform npcGO; 
    public float moveSpeed; //.035f
    Vector3 intendedPosition;
    float distance;
    float adjustedX, adjustedY, adjustedZ;
    bool flag;

    private void OnTriggerStay2D(Collider2D collider2D)
    {
        npcGO.transform.position = GetPartialVectorThree(npcGO.position, player.position);
    }

    Vector3 GetPartialVectorThree(Vector3 npc, Vector3 player)
    {
        float newX = 0, newY = 0, newZ = 0;
                
        if (npc.x < player.x)
            newX += npc.x + moveSpeed;
        if (npc.x > player.x)
            newX += npc.x - moveSpeed;
        
        if (npc.y < player.y)
            newY += npc.y + moveSpeed;
        if (npc.y > player.y)
            newY += npc.y - moveSpeed;
        
        if (npc.z < player.z)
            newZ += npc.z;
        
        return new Vector3(newX, newY, newZ);
    }

    void TransitionToBattle()
    {
        PlayerData ai = PlayerData.GetRandomPlayerData("Monkey");
        AiBattleStats.name = ai.name;
        AiBattleStats.health = ai.health;
        AiBattleStats.attack = ai.attack;
        AiBattleStats.defense = ai.defense;
        AiBattleStats.element = ai.element;

        SceneManager.LoadScene("BattleScene");
    }
}

public class AiBattleStats
{
    public static string name;
    public static int health, attack, defense;
    public static GameEnums.Type element;
}
