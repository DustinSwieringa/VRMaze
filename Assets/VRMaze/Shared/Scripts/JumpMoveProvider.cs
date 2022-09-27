using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class JumpMoveProvider : ActionBasedContinuousMoveProvider
{
    [SerializeField]
    private InputActionProperty _jumpActionProperty;

    [SerializeField]
    private CharacterController _characterController;

    public float JumpSpeed = 0.2f;
    public float GravityMultiplier = 0.1f;
    public int JumpCount = 1;

    private float _yVelocity;

    private int _jumpCounter;

    private new void OnEnable()
    {
        _jumpActionProperty.action.performed += JumpAction;
        base.OnEnable();
    }

    private new void OnDisable()
    {
        _jumpActionProperty.action.performed -= JumpAction;
        base.OnDisable();
    }

    private void JumpAction(InputAction.CallbackContext obj)
    {
        if (!_isJumping || _jumpCounter < JumpCount)
        {
            _isJumping = true;
            _jumpCounter++;
            _yVelocity += JumpSpeed;
            StartCoroutine(JumpGrace());
        }
    }

    private bool _isJumping;
    private bool _justJumped;

    private IEnumerator JumpGrace()
    {
        _justJumped = true;
        yield return new WaitForSeconds(0.3f);
        _justJumped = false;
    }

    private void FixedUpdate()
    {
        bool isGrounded = Physics.Raycast(new Ray(_characterController.transform.position + new Vector3(0, 0.1f, 0), Vector3.down), 0.1f);
        if (isGrounded && !_justJumped)
        {
            _isJumping = false;
            _yVelocity = 0;
            _jumpCounter = 0;
        }
        else
        {
            _yVelocity += Physics.gravity.y * GravityMultiplier * Time.deltaTime;
        }

        _characterController.Move(new Vector3(0, _yVelocity, 0));
    }
}
