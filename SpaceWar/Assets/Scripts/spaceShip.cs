using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShip : MonoBehaviour
{
    float v = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxisRaw("Horizontal");
        float yDirection = Input.GetAxisRaw("Vertical");

        float xMove = xDirection * Time.deltaTime * v;
        float yMove = yDirection * Time.deltaTime * v;

        if ((xDirection < 0 && transform.position.x < -8.24) ||(xDirection > 0 && transform.position.x > 8.24)) return;
        if ((yDirection < 0 && transform.position.y < -4.4) ||(yDirection > 0 && transform.position.y > 4.4)) return;

        transform.position += new Vector3(xMove, yMove, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            Debug.Log("triggerrr");
        }
    }
}
