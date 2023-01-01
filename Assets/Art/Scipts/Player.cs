using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 控制角色移动、动画等
/// </summary>
public class Player : MonoBehaviour
{

    public float speed = 5;//速度

    Rigidbody2D rbody;//刚体组件
    
    // Start is called before the first frame update
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveX * speed * Time.deltaTime;
        transform.position = position;
    }
}
