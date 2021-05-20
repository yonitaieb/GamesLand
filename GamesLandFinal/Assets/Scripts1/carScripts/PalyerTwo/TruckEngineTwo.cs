using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckEngineTwo : MonoBehaviour
{
    float timeCreate = 0;


    private void Awake()
    {
        timeCreate = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 8 * Time.deltaTime, 0);
        transform.localScale = new Vector2(4, 3);
        if (Time.time - timeCreate > 3)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
