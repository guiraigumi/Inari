using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private CharacterController controller;
    private Animator anim;
    
    [SerializeField] private float speed;
    public bool isplayerTalking = true;
    public float gravity = -9.81f;
    
    public LayerMask groundMask;
    [SerializeField] private bool isGrounded;
    public Transform groundSensor;
    public float sensorRadius;

    private float currentVelocity;
    [SerializeField] private float smoothTime;

    private Vector3 playerVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxisRaw("Vertical");
        anim.SetFloat("VelZ", z);
        
        float x = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("VelX", x);

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        isGrounded = Physics.CheckSphere(groundSensor.position, sensorRadius, groundMask);

        if(isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }

        if (movement != Vector3.zero && !isplayerTalking)  
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref currentVelocity, smoothTime);

            transform.rotation = Quaternion.Euler(0, smoothAngle, 0);
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            movement *= speed;

            controller.Move(movement * Time.deltaTime);

            playerVelocity.y += gravity * Time.deltaTime;

            controller.Move(playerVelocity * Time.deltaTime);
        }

    }

      void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
           SceneManager.LoadScene("Battle Scene");

           Debug.Log("Batalla");
        }
    }

    

}
