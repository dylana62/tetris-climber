using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimberController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float horizSpeed = 1f;
    public float vertSpeed = 0.7f;

    float horizIn;
    float vertIn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizIn = Input.GetAxisRaw("Horizontal");
        vertIn = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizIn * horizSpeed, vertIn * vertSpeed);
    }
}
