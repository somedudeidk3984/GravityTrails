using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;
    public float yDirection;
    private Rigidbody2D enemyRigidBody;
    public int maximumXPosition;
    public int minimumXPosition;

    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition)
        {
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }
        if (transform.position.x >= maximumXPosition)
        {
            xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "Player")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
        if (collision.gameObject.tag == "ThrowingObject")
        {
            GameObject.FindObjectOfType<Teleport>().enemyCount--;
        }
    }
}
