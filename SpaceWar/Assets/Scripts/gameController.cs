using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject enemy;
    public float downTime = 3;
     float m_downTime;
    // Start is called before the first frame update
    void Start()
    {
        m_downTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_downTime -= Time.deltaTime;

        if (m_downTime <= 0)
        {
            spawnEnemy();
            m_downTime = downTime;
        }

        
    }

    void spawnEnemy()
    {
        Vector2 enemyPos = new Vector2(Random.Range(-8, 8), 5);

        if (enemy != null)
        {
            Instantiate(enemy, enemyPos, Quaternion.identity);
        }
    }
}

