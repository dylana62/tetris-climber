using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ClimberController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Board board;
    [SerializeField] Tile skullBlock;
    public float horizSpeed = 1f;
    public float vertSpeed = 0.7f;
    public float fallSpeed = 2f;

    float horizIn;
    float vertIn;
    bool isFalling;
    Vector2 fallPos;
    Vector3Int gridPos;
    

    // Update is called once per frame
    void Update()
    {
        // Check if player is on the same tile as a skull tile
        gridPos = new Vector3Int((int)Mathf.Floor(this.transform.position.x), (int)Mathf.Floor(this.transform.position.y), 0);
        var tilemapTile = board.tilemap.GetTile(gridPos);
        //Debug.Log(tilemapTile);
        if (tilemapTile == skullBlock) {
            board.GameOver(1);
        }

        if (!isFalling) {
            horizIn = Input.GetAxisRaw("Horizontal");
            vertIn = Input.GetAxisRaw("Vertical");
        }
        
        if (this.transform.position.y >= 10)
        {
            //this.transform.position.y = -9.5;
            board.GameOver(2);
        }

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
    }
}
