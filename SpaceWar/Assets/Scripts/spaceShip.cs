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

        transform.position += new Vector3(xMove, yMove, 0);
    }
}
