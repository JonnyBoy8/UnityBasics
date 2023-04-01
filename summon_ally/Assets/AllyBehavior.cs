using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void MoveObject()
    {
        Vector3 pos = transform.position;

        if(Input.GetKey(KeyCode.I))
        {
            pos.y += speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.K))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.J))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.L))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
