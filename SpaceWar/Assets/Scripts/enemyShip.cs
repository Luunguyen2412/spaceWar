using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -3 * Time.deltaTime, 0);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
