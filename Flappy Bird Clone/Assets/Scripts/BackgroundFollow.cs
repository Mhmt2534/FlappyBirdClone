using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    [SerializeField]
    Transform bird, backGround,floor;

    Vector2 endPos;

    //6.78

    [SerializeField]
    float minY, maxY,ekle;

    private void Start()
    {
        
    }

    private void Update()
    {
        CameraLimit();
        MoveBackGround();
    }

    public void CameraLimit()
    {
        transform.position=new Vector3(bird.position.x,Mathf.Clamp(transform.position.y,minY,maxY) ,transform.position.z);
    }

    public void MoveBackGround()
    {
        Vector2 distance = new Vector2(transform.position.x - endPos.x, transform.position.y - endPos.y);

        Vector2 different=new Vector2(floor.position.x-backGround.position.x, floor.position.y - backGround.position.y);

        backGround.position += new Vector3(distance.x, distance.y, 0f) * 1f;
        if (different.x<0)
        {
            floor.position+=new Vector3(3.6f,0,0);
        }

        endPos = transform.position;

    }

}
