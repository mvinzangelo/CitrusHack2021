using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayBottle : MonoBehaviour
{
    private Vector3 touchPosition;
    private ParticleSystem particles;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        particles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;
            particles.Play();

            if (touch.phase == TouchPhase.Ended)
            { 
                rb.velocity = Vector2.zero;
            }
        }
        else 
        { 
            rb.velocity = Vector2.zero;
            rb.angularDrag = 0;
            rb.angularVelocity = 0;
            particles.Pause();
            particles.Clear();
        }
    }
}
