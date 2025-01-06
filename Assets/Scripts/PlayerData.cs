using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerData 
{
    public static string Name;
    public static int Health, Attack, Defense;
    public GameEnums.Type Element;


    public PlayerData()
    {
        //will eventually need to load from previous scene or read/write a file
        Name = "Default";
        Health = 10;
        Attack= 10;
        Defense = 10;
    }

    public PlayerData(string name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
        int randElement = Random.Range(0, 4);
        Element = (GameEnums.Type)randElement;
    }

    private PlayerData(string name)
    {
        Name = name;
        Health = Random.Range(10,18);
        Attack = Random.Range(10, 18);
        Defense = Random.Range(10, 18);
        int randElement = Random.Range(0, 4);
        Element = (GameEnums.Type)randElement;
    }

    public static PlayerData GetRandomPlayerData(string name)
    {
        return new PlayerData(name);
    }

    public string GetPlayerStats()
    {
        string characterStats;

        characterStats = $"name: {Name}\n" +
            $"Health: {Health}\n" +
            $"Attack: {Attack}\n" +
            $"Defense: {Defense}";

        return characterStats;
    }

    public string name
    {
        get { return Name; }
        set { value = Name; }
    }
    public int health
    {
        get { return Health; }
        set { value = Health; }
    }
    public int attack
    {
        get { return Attack; }
        set { value = Attack; }
    }
    public int defense
    {
        get { return Defense; }
        set { value = Defense; }
    }
    public GameEnums.Type element
    {
        get { return Element; }
        set { value = Element; }
    }
}
