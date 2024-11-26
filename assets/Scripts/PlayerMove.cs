using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float force = 10f;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ApplyForce();
        }
    }

    void ApplyForce() 
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    // public InputAction playerControls;
    // public Vector3 flap;
    // [SerializeField] float speed = 10f;
    // [SerializeField] float jumpSpeed = .5f;
    // Vector3 moveDirection = Vector3.zero;



    // void OnEnable() {
    //     playerControls.Enable();
    // }

    // void OnDisable() {
    //     playerControls.Disable();
    // }



    // private void Update() {
    //     rb.AddForce(flap * speed * Time.deltaTime);
    // }

    // void Start() {
    //     rb = GetComponent<Rigidbody>();
    // }

    // private void FixedUpdate() {
    //     rb.AddForce(flap * jumpSpeed, ForceMode.Impulse);
    // }

    // public void OnMove(InputValue value)
    // {
    //     flap = value.Get<Vector3>();
    // }

    // public void OnFire(Input value)
    // {
    //     rb.AddForce(Vector3.up * jumpSpeed);
    // }
}
