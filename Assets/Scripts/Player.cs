using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform cameraTransform;

    void Update()
    {
        Vector3 move = Vector3.zero;

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        if (Keyboard.current.wKey.isPressed)
            move += forward;

        if (Keyboard.current.sKey.isPressed)
            move -= forward;

        if (Keyboard.current.dKey.isPressed)
            move += right;

        if (Keyboard.current.aKey.isPressed)
            move -= right;

        if (move != Vector3.zero)
        {
            transform.position += move.normalized * speed * Time.deltaTime;

            transform.forward = move.normalized;
        }
    }
}