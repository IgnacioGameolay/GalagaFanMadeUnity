using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    float h;
    float v;
    Vector3 moveDirection;
    [SerializeField] float speed = 15f;

    private void ReadInput()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        moveDirection.x = h;
        moveDirection.y = v;
    }
    void Start()
    {
        
    }
    void Update()
    {
        ReadInput();
        transform.position += moveDirection * speed * Time.deltaTime; 
    }
}
