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
    public static GameManager GameManager;

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
            if (temp.x >= maxX)
            {
                move_Speed = -1.42f;

            }
            else if (temp.x <= minX)
            {
                move_Speed = 1.42f;
            }
            if(temp.x<maxX || temp.x>minX)
                temp.x += move_Speed * Time.deltaTime;

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
        if(collision.transform.tag == transform.tag)
        {
            GameManager.instance.AddSkor(1);

        }

        if(collision.transform.tag != "Kose")
        {
            Destroy(gameObject);
            GameManager.instance.SpawnItem();
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GameManager.instance.itemObj=null;
    }

}
