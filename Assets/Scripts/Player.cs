using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    float h;
    float v;
    Vector3 moveDirection;
    [SerializeField] float speed = 15f;
    [SerializeField] int health = 10;
    [SerializeField] Transform BulletPrefab;
    private void ReadInput()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        moveDirection.x = h;
        moveDirection.y = v;
    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
            ReadInput();
        Shoot();
        transform.position += (moveDirection.normalized * speed) * Time.deltaTime; 
    }

    public void TakeDamage()
    {
        health--;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage();
        }
    }
}
