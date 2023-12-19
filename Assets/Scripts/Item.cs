using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{

    private Rigidbody2D rb;
    public float minX;
    public float maxX;
    public float move_Speed;
    private bool canMove;
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canMove = true;


    }

    // Update is called once per frame
    void Update()
    {
        MoveItem();

        if (Input.touchCount == 1)
        {
            DropItem();
        }
    }

    void MoveItem()
    {
        if (canMove)
        {

            Vector3 temp = transform.position;

            temp.x += move_Speed * Time.deltaTime;

            if (temp.x > maxX)
            {
                move_Speed *= -1f;

            }
            else if (temp.x < minX)
            {
                move_Speed *= -1f;
            }

            transform.position = temp;
        }
    }

    private void DropItem()
    {
        canMove = false;
        rb.gravityScale = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box1"))
        {
            Destroy(gameObject);
            GameManager.instance.AddSkor(value);
        }
        else
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Box2"))
        {
            Destroy(gameObject);
            GameManager.instance.AddSkor(value);
        }
        else
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Box3"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.AddSkor(value);
        }
        else
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Box4"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.AddSkor(value);
        }
        else
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Box4"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.AddSkor(value);
        }
        else
        {
            Destroy(collision.gameObject);
        }

    }

}
