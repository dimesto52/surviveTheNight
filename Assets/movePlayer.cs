using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movePlayer : MonoBehaviour
{
    public Vector2 moveDirection = Vector2.zero;
    public float speed = 5;

    SpriteRenderer render
    {
        get
        {
            return this.GetComponent<SpriteRenderer>();
        }
    }

    private void FixedUpdate()
    {
        if (isOn)
        {
            render.flipX = moveDirection.x > 0;
            transform.position += (Vector3)moveDirection * Time.fixedDeltaTime * speed;
        }
    }
    public void onMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();

    }
    bool isOn = false;
    public void setMod(Playmod mod)
    {
        isOn = (Playmod.run == mod);
    }
    public void dead()
    {
        isOn = false;
    }
}
