using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    Rigidbody rb;
    float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(new Vector3(-1, 0, 0));
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        //destroy out of bounds
        if (transform.position.x < -20)
            Destroy(gameObject);
    }
}
