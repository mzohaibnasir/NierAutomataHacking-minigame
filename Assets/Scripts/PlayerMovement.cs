using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    // private PlayerActions _playerActions;
    private Rigidbody _rbody;
    private float _movementX;
    private float _movementY;
    // private Vector2 _moveInput;



    private void Awake() {
        // _playerActions = new PlayerActions();
        _rbody = GetComponent<Rigidbody>();
        _speed =20.0f;

    }

    // private void OnEnable() {
    //     _playerActions.Player.Enable()
    // }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue){
        // Debug.Log("Moved"+ movementValue);
        Vector2 movementVector = movementValue.Get<Vector2>();
        // Debug.Log("Moved-Vector"+ movementVector);
        _movementX=movementVector.x;
        _movementY=movementVector.y;
    }

    private void FixedUpdate() {
        Vector3 movement =new Vector3(_movementX, 0.0f ,_movementY);
        // Debug.Log(movement +" "+ _speed);
        
        _rbody.AddForce(movement * _speed);
    }
}
