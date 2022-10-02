using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cursorShow : MonoBehaviour
{
    Vector2 pointerPos = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        float X_size = Camera.main.orthographicSize * Camera.main.aspect;
        float Y_size = Camera.main.orthographicSize;

        float width_2 = Screen.width / 2;
        float height_2 = Screen.height / 2;

        float x = ((pointerPos.x - width_2) / width_2 ) * X_size;
        float y = ((pointerPos.y - height_2) / height_2) * Y_size;

        Vector3 pos = new Vector3(Camera.main.transform.position.x + x, Camera.main.transform.position.y + y, 0);

        transform.position = pos;
    }

    public void onMovePointer(InputAction.CallbackContext context)
    {
        pointerPos = context.ReadValue<Vector2>();
        
    }
}
