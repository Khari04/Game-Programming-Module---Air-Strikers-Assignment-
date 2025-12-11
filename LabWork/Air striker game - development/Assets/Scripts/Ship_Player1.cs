using UnityEngine;

public class Ship_Player1 : MonoBehaviour
{

    [SerializeField]
    private float speed;
    public float rotationSpeed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

        if (movementDirection != Vector2.zero)
        {
            //Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Rad2Deg* Mathf.Atan2(verticalInput, horizontalInput)); 

           //rb.AddRelativeForce(movementDirection*speed);

            //rb.linearVelocityX = horizontalInput * speed;
            //rb.linearVelocityY = verticalInput * speed;





        }

    }
}
