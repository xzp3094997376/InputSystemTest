using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class Test : MonoBehaviour
{
    //public PlayerInput playerInput;
    // Start is called before the first frame update
    public TestInput testInput;
    void Start()
    {
        Debug.Log("fdf");
        testInput=new TestInput();
        testInput.Enable();
        testInput.Player.Move.performed += (ctx) =>
        {
            transform.Translate(ctx.ReadValue<Vector2>());
        };
        testInput.Newactionmap.Newaction1.performed += (ctx) =>
        {
            Debug.Log("有键盘按下");
        };
    }

    void OnDestroy()
    {
        testInput.Disable();
    }
}   
            