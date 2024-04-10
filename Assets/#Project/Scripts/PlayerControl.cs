using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    //public InputActions actions;
    public InputActionAsset actions;
    public float speed = 2f;
    private InputAction xAxis;
    public InputAction jump;
    public float jumpHeight;

    void Awake()
    {
        xAxis = actions.FindActionMap("CubeActionsMap").FindAction("XAxis");
        jump = actions.FindActionMap("CubeActionsMap").FindAction("Jump");
        jump.performed += ctx => {OnJump(ctx);};
    }

    void OnEnable()
    {
        actions.FindActionMap("CubeActionsMap").Enable();
        jump.Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("CubeActionsMap").Disable();
        jump.Disable();
    }

    void Update()
    {
        MoveX();
    }

    private void MoveX()
    {
        float xMove = xAxis.ReadValue<float>();
        transform.position += speed * Time.deltaTime * xMove * transform.right;
        //transform.Translate(0, 0, speed * Time.deltaTime );
        transform.position += speed * Time.deltaTime  * transform.forward;
    }
    public void OnJump(InputAction.CallbackContext ctx){
        if (transform.position.y > 0.6){
            return;
        }
        Vector3 jumpAction;
        jumpAction.y = jumpHeight;
        jumpAction.x = transform.position.x;
        jumpAction.z = transform.position.z;
        transform.position = jumpAction; 
    }
}
