using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;
    Vector2 moveInput;
    public float moveSpeed;
    PlayerData playerData;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        playerData = PlayerData.GetRandomPlayerData("Jair");
        rb2d = GetComponent<Rigidbody2D>();

        Debug.Log(playerData.GetPlayerStats());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveInput.x * moveSpeed * Time.deltaTime, moveInput.y * moveSpeed * Time.deltaTime);

        moveInput.Normalize();
    }

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");


        animator.SetFloat("ewSpeed", Mathf.Abs(moveInput.x));
        //animator.SetFloat("ewSpeed", Mathf.Abs(moveInput.y));

        if (moveInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }

    }
}
