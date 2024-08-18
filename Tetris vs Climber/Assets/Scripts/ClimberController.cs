using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimberController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float horizSpeed = 1f;
    public float vertSpeed = 0.7f;
    public float fallSpeed = 2f;

    float horizIn;
    float vertIn;
    bool isFalling;
    Vector2 fallPos;

    // Update is called once per frame
    void Update()
    {
        if (!isFalling) {
            horizIn = Input.GetAxisRaw("Horizontal");
            vertIn = Input.GetAxisRaw("Vertical");
        }
        
        if (Input.GetKeyDown(KeyCode.F)) BeginFall(2);

    }

    void FixedUpdate()
    {
        if (!isFalling) {
            rb.velocity = new Vector2(horizIn * horizSpeed, vertIn * vertSpeed);
        }
        // Logic for if player is falling
        else {
            if (this.transform.position.y > fallPos.y && this.transform.position.y > -9.5)
            {
                rb.velocity = new Vector2(0, -1 * fallSpeed);
            }
            else 
            {
                isFalling = false;
            }
        }
    }

    // Initiate fall for certain distance. Called by board when lines are cleared
    public void BeginFall(float distance) {
        isFalling = true;

        fallPos = new Vector2(this.transform.position.x, this.transform.position.y - distance);
        Debug.Log(fallPos);

    }
}
