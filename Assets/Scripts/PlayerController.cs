using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using CommandPattern;
using CommandPattern.commands;

public class PlayerController : MonoBehaviour
{
    private float horInput;
    private float vertInput;
    //public Animator animator;
    public float speed;
    private Rigidbody2D player;
    private Vector2 movementInput = Vector2.zero;
    public Transform firePoint;
    public MoveObject moveObject;

    private Command upButton;
    private Command downButton;
    private Command leftButton;
    private Command rightButton;

    // Start is called before the first frame update
    void Start()
    {
        upButton = new SpeedUp(moveObject);
        downButton = new SlowDown(moveObject);
        leftButton = new StrafeLeft(moveObject);
        rightButton = new StrafeRight(moveObject);

        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ExecuteNewCommand(upButton);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            ExecuteNewCommand(leftButton);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ExecuteNewCommand(downButton);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ExecuteNewCommand(rightButton);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveObject.Go();
    }

    public void onMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }


    private void ExecuteNewCommand(Command commandButton)
    {
        commandButton.Execute();
    }

    /*  public void onShoot(InputAction.CallbackContext con text)
        {
            if (context.performed)
            {
                PlayerShoot();
            }
        }

        private void PlayerShoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        } */
}
