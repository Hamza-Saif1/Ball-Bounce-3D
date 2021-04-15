using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 3;
    public Rigidbody2D rigidbody1;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();
        Debug.Log("Start Gun");
    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        rigidbody1.velocity = new Vector3(mov * speed,rigidbody1.velocity.y,0);    //ball movement
        if (Input.GetKeyDown(KeyCode.Space)) {                                        //jump space button code
            rigidbody1.velocity = new Vector2(rigidbody1.velocity.x, speed); // x-axis, y-axis, z-axis
        }
        Debug.Log(mov);
    }
}
hamza
