using UnityEngine;

public class BombBehavior : MonoBehaviour
{
    void Start()
    {
        
    }

    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    public void DetonateBomb()
    {
        GameObject blast = Instantiate(Resources.Load("Prefabs/BlastRadius") as GameObject);
        Vector3 p = this.transform.position;
        blast.transform.position = p;
        Destroy(this.gameObject);
    }

    void MoveObject()
    {
        Vector3 pos = transform.position;

        if(Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.E))
        {
            DetonateBomb();
        }

        transform.position = pos;
    }
}
