using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public partial class PlayerStateManager
{
    public CharacterController controller;
    public PlayerInput input;

    public Vector3 moveVector;
    public Vector2 inputVector;
    public float playerSpeed = 10;
    public float playerRotateSpeed = 1000;

    private Vector3 gravityVector;
    private Vector3 isometricImput;
}
