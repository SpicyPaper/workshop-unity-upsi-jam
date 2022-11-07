using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private TMP_Text collectedText;
    [SerializeField] private TMP_Text vitoryText;
    [SerializeField] private Transform collectParent;

    private float collected;
    private bool grounded;
    private Rigidbody2D body;
    private int initialCollectibles;
    private Animator anim;

    private void Awake()
    {
        initialCollectibles = collectParent.childCount;
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Movement
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        // Sprite direction
        if (horizontalInput < 0.05f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput > 0.05f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // Jump
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }

        collectedText.text = "Collected: " + collected;

        // Victory
        if (collected == initialCollectibles)
        {
            vitoryText.gameObject.SetActive(true);
        }

        // Animator
        anim.SetBool("Run", Mathf.Abs(horizontalInput) > 0.05f);
        anim.SetBool("Grounded", grounded);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "collect")
        {
            Destroy(collision.gameObject);
            collected++;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
            grounded = true;
        }
    }


    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpSpeed);
        anim.SetTrigger("Jump");
        grounded = false;
    }
}
