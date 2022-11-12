using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private TMP_Text collectedText = null;
    [SerializeField] private Animator anim = null;
    [SerializeField] private TMP_Text victoryText = null;
    [SerializeField] private Transform collectibleParent = null;
    [SerializeField] private float jumpSpeed = 10;
    [SerializeField] private float speed = 10;

    private Rigidbody2D body = null;
    private bool grounded = false;
    private int collected;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }

        collectedText.text = "Collected: " + collected;

        if (collectibleParent.childCount <= 0)
        {
            victoryText.gameObject.SetActive(true);
        }

        anim.SetBool("Run", Mathf.Abs(horizontalInput) > 0.05f);
        anim.SetBool("Grounded", grounded);

        if (horizontalInput < 0.05f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput > 0.05f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "collect")
        {
            collected++;
            Destroy(collision.gameObject);
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
