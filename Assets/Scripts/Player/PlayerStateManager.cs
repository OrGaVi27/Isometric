using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class PlayerStateManager : MonoBehaviour
{
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        input = GetComponent<PlayerInput>();

        gravityVector = new Vector3(0, -15f, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ApplyGravity();
        Rotate();
    }

    #region Movement

    public void ApplyGravity()
    {
        controller.Move(gravityVector * Time.deltaTime);
    }

    private void Move()
    {
        var matrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
        isometricImput = matrix.MultiplyPoint3x4(moveVector);

        controller.Move(isometricImput * playerSpeed * Time.deltaTime);
    }

    public void Rotate()
    {
        if (isometricImput.magnitude == 0)return;

        var rotation = Quaternion.LookRotation(isometricImput);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, playerRotateSpeed * Time.deltaTime);
    }

    #endregion
}
