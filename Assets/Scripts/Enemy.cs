using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Vector3 moveDirection;
    [SerializeField] float h = 1f;
    [SerializeField] float v = -1f;
    [SerializeField] int health = 3;
    [SerializeField] float fireRate = 1f;
    [SerializeField] Transform enemyBulletPrefab;
    [SerializeField] Transform chooseWave;
    public int score;
    bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot)
        {
            Shoot();
        }        
        moveDirection.x += h;
        moveDirection.y = v;

        transform.position = Vector3.MoveTowards(transform.position, moveDirection, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Limit"))
        {
            v -= 5f;
            h *= -1;
            moveDirection.x *= -1;
        }
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage();
        }
    }

    private void Shoot()
    {
        canShoot = false;
        Instantiate(enemyBulletPrefab, transform.position, Quaternion.identity);
        StartCoroutine(ShootDelay());
    }
    IEnumerator ShootDelay() {
        yield return new WaitForSeconds(1/fireRate);
        canShoot = true;
    }
    
    private void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            GameManager.Instance.Score += score;
            Destroy(gameObject);
        }
    }
}
