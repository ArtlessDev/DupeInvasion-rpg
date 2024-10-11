using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;
    Vector2 moveInput;
    public float moveSpeed;
    public BoxCollider2D bc2d;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        PlaceInteractionBox();

        moveInput.Normalize();
    }

    void Update()
    {
        rb2d.velocity = moveInput * moveSpeed * Time.deltaTime;
    }

    void PlaceInteractionBox()
    {
        if (moveInput.x < 0)
        {
            bc2d.offset = new Vector2(-1, 0);
            //bc2d.offset = 0;
        }
        else if (moveInput.x > 0)
        {
            bc2d.offset = new Vector2(1, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        var npc = col.GetComponent<NonPlayableCharacters>();
        Debug.Log($"{col.name}: {npc.Profile}");
    }
}
