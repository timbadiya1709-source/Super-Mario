using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMOvement : MonoBehaviour
{
    Rigidbody rb;
    public float addforce;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalpos = Input.GetAxis("Horizontal");
        float verticalpos = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalpos,verticalpos,0f);
        transform.Translate(movement *addforce *Time.deltaTime);

    }

}
