using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float TorqueAmount = 10f; // Amount of torque to apply when pressing the key
    [SerializeField] float boostSpeed = 30f; // Speed to boost the player
    [SerializeField] float baseSpeed = 20f; // Base speed of the player

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true; // Flag to check if the player can move

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = Object.FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
        
    }

    public void DisableControls()
    {
        canMove = false; // Disable player controls
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        { 
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-TorqueAmount);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(TorqueAmount);
        }
    }
}
