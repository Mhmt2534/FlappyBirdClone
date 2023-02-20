using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BirdMove : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float upSpeed, downSpeed;
    float point;
    

    bool timeCont=true;

    [SerializeField]
    TMP_Text text;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        point = 0;
    }

    private void Update()
    {
        rb.velocity = new Vector2(2,rb.velocity.y);

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (downSpeed - 1) * Time.deltaTime;
        }

        BirdFly();
    }

    public void BirdFly()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && timeCont)
        {
            Time.timeScale = 1;
            rb.velocity=new Vector2(1,upSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            timeCont = false;
        }

        if (collision.CompareTag("Point"))
        {
            point++;
            text.text = point.ToString();
        }
    }

}
