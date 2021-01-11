using UnityEngine;

class Ball : MonoBehaviour
{
    public Bat bat;
    public float size = 1.0f;
    float speed = 0.2f;
    int score = 10;
    float directionX = 1.0f;
    float directionY = 0.5f;

    void Start()
    {
        speed = 0.2f / size;

        float fractionalScore = 10 / size;
        score = (int)fractionalScore;

        string message = name + (" size is ") + size + (", speed is ") + speed + (", score is ") + score;

        print(message);
    }

    protected virtual void FixedUpdate()
    {
        Vector3 scale = new Vector3();
        scale.x = size;
        scale.y = size;
        transform.localScale = scale;

        // adds velocity to ball to make it move from original position
        Vector3 position = transform.localPosition;
        position.x += speed * directionX;
        position.y += speed * directionY;
        transform.localPosition = position;
    }

 
    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            // Change Ball's direction when it collides with Left and Right Wall
            case "Left Wall":
            case "Right Wall":
                directionX = -directionX;
                break;

            // Change Ball's direction when it collides with Bat and Bricks
            case "Bat":
            case "Top Wall":
            case "Brick":
            case "Brick(1)":
            case "Brick(2)":
            case "Brick(3)":
            case "Brick(4)":
            case "Brick(5)":
            case "Brick(6)":
            case "Brick(7)":
            case "Brick(8)":
            case "Brick(9)":
            case "Brick(10)":
            case "Brick(11)":
            case "Brick(12)":
            case "Brick(13)":
            case "Brick(14)":
            case "Brick(15)":
            case "Brick(16)":
            case "Brick(17)":
            case "Brick(18)":
            case "Brick(19)":
            case "Brick(20)":
            case "Brick(21)":
            case "Brick(22)":
            case "Brick(23)":
            case "Brick(24)":
            case "Brick(25)":
            case "Brick(26)":
            case "Brick(27)":
            case "Brick(28)":
            case "Brick(29)":
            case "Brick(30)":
            case "Brick(31)":
            case "Brick(32)":
                directionY = -directionY;
                break;

            
            case "Bottom Wall":
                // Destroys ball when it collides with Bottom Wall
                Destroy(gameObject);
                break;
            default:
                // If the ball has hit something not listed above, log a console message
                print(name + " has collided with " + other.gameObject.name);
                break;
        }
    }}