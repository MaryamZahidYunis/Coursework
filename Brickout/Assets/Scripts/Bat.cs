using UnityEngine;
using UnityEngine.UI;class Bat : MonoBehaviour
{
    public KeyCode moveRightKey = KeyCode.RightArrow;
    public KeyCode moveLeftKey = KeyCode.LeftArrow;
    bool canMoveRight = true;
    bool canMoveLeft = true;
    public float speed = 0.2f;
    float direction = 0.0f;

    void FixedUpdate()
    {
        // veloity of Bat changes from current position
        Vector3 position = transform.localPosition;
        position.x += speed * direction;
        transform.localPosition = position;
    }    void Update()
    {
        // right and left arrow key need to be pressed for Bat to move
        bool isRightPressed = Input.GetKey(moveRightKey);
        bool isLeftPressed = Input.GetKey(moveLeftKey);

        // If right arrow key is pressed bat will move to the right
        if (isRightPressed && canMoveRight)
        {
            direction = 1.0f;
        }
        // If left arrow key is pressed Bat will move to the left
        else if (isLeftPressed && canMoveLeft)
        {
            direction = -1.0f;
        }
        //If no key is pressed Bat will not move
        else
        {
            direction = 0.0f;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            // To make sure the Bat does not go past the Right and Left Wall when right and left arrow key is pressed
            case "Right Wall":
                canMoveRight = false;
                break;
            case "Left Wall":
                canMoveLeft = false;
                break;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            //To make the Bat be able to come back after hitting Right and Left Wall by pressing right and left arrow keys
            case "Right Wall":
                canMoveRight = true;
                break;
            case "Left Wall":
                canMoveLeft = true;
                break;
        }
    }
}