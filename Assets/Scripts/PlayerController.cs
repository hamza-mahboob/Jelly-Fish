using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 startPos, startScale;
    float speed = 5.0f;
    float pillarX, pillarY, pillarZ;
    float topX, topY;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startScale = transform.localScale;
        Physics.gravity = Vector3.down * 20;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //taking the trigger collider's size and setting the cube's scale to that size
            transform.localScale = collision.gameObject.GetComponent<Collider>().bounds.size;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.position = startPos;
        transform.localScale = startScale;
        //add score using game manager
        FindObjectOfType<GameManager>().addScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //get all child colliders of obstacles
        //get dimensions of pillar and top in an obstacle
        //set localScale to these dimensions after some calculations
    }
}
