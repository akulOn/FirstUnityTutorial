using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;

        // Time.deltaTime 
        // time between every frame
        // makes movement smother
        position.x += Speed * horizontal * Time.deltaTime;
        position.y += Speed * vertical * Time.deltaTime;

        transform.position = position;
    }
}
