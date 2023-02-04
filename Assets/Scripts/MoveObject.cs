using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float MOVE_STEP_DISTANCE = .05f;
    private const float MOVE_STEP_MIN = .05f;
    private const float MOVE_STEP_MAX = 5f;
    private const float MOVE_STEP_MODIFIER = .1f;

    //These methods will be executed by their own command
    public void SpeedUp()
    {
        if (MOVE_STEP_DISTANCE < MOVE_STEP_MAX)
        {
            MOVE_STEP_DISTANCE += MOVE_STEP_MODIFIER;
        }
    }

    public void SlowDown()
    {
        if (MOVE_STEP_DISTANCE > MOVE_STEP_MIN)
        {
            MOVE_STEP_DISTANCE -= MOVE_STEP_MODIFIER;
        }
    }

    public void StrafeLeft()
    {
        Move(Vector2.left);
    }

    public void StrafeRight()
    {
        Move(Vector2.right);
    }

    //Help method to make it more general
    private void Move(Vector2 direction)
    {
        transform.Translate(direction * MOVE_STEP_DISTANCE);
    }

    public void Go()
    {
        transform.Translate(Vector2.up * MOVE_STEP_DISTANCE);
    }
}
