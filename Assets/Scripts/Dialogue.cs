using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class Dialogue
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    private int index;
    public float textSpeed;

    /// <summary>
    /// NEED TO ADD INTERACTIVITY FOR OPTIONS INTO DIALOGUE BOX
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        var npc = col.GetComponent<NonPlayableCharacters>();
        Debug.Log($"{col.name}: {npc.Profile}");
    }


    public void StartDialogue()
    {
        index = 0;
        //StartCoroutine(TypeLine());
    }

    public static string TypeLine(Collider2D col)
    {
        var npc = col.GetComponent<NonPlayableCharacters>();
        

        if (npc != null)
        {
            var line = npc.Profile[0];
            return line;
        }

        return "";
        //var npc = col.GetComponent<NonPlayableCharacters>();
        
        //foreach (char c in col.Profile.lines[index].ToCharArray()) 
        //{
        //    textComponent.text += c;
        //    yield return new WaitForSeconds(textSpeed);
        //}
    }
}
