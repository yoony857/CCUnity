using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    int speedAmt = 10;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -27)
        {
            speedAmt = 10;
        }

        if (transform.position.x >= 27)
        {
            speedAmt = -10;
        }

        transform.Translate(speedAmt * Time.deltaTime, 0, 0);

    }
}