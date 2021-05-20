using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeEngineTwo : MonoBehaviour
{
    float timeCreate = 0;


    private void Awake()
    {
        timeCreate = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 15 * Time.deltaTime, 0);
        transform.localScale = new Vector2(2, 2);
        if (Time.time - timeCreate > 3)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
