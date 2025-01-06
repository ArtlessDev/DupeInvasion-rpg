using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExternalTrigger : MonoBehaviour
{
    public BoxCollider2D bc2d;
    public TextMeshProUGUI textComponent;
    public GameObject canvas;
    public Rigidbody2D rb2d;
    string upcomingDialogue;

    
    // Update is called once per frame
    void Update()
    {
        PlaceInteractionBox();
        InteractWithDialogue();
    }


    void PlaceInteractionBox()
    {
        if (rb2d.velocity.x < 0)
        {
            bc2d.offset = new Vector2(-1, 0);
        }
        else if (rb2d.velocity.x > 0)
        {
            bc2d.offset = new Vector2(1, 0);
        }
    }

    void InteractWithDialogue()
    {
        if (!string.IsNullOrEmpty(upcomingDialogue) && Input.GetKeyDown("z"))
        {
            Debug.Log(upcomingDialogue);
            canvas.SetActive(true);

            textComponent.text = upcomingDialogue;
        }

    }

    //this gets rid of it
    private void OnTriggerExit2D(Collider2D collision)
    {
        upcomingDialogue = null;
        canvas.SetActive(false);
    }
}
