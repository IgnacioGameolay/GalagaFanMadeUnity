using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Vector3 moveDirection;
    [SerializeField] float h = 1f;
    [SerializeField] float v = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.x += h;
        moveDirection.y = v;

        transform.position = Vector3.MoveTowards(transform.position, moveDirection, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Limit"))
        {
            v -= 0.1f;
            speed *= -1;
        }
    }
}
