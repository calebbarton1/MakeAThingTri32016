using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirVert = Input.GetAxis("Vertical");
        float moveDirHor = Input.GetAxis("Horizontal");
        Move(moveDirHor, moveDirVert);
    }

    public void Move(float dir1, float dir2)
    {
        rb.velocity = new Vector2(dir1, dir2) * speed;
    }
}
