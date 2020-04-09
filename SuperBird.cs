using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBird : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject sum;
    public float jumpPower = 5f;
    public float forwardPower = 0.2f;
    public GamePlayManager manager;
    void Awake() {
        rb.GetComponent<Rigidbody>();
        manager = GameObject.FindObjectOfType<GamePlayManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
     void FixedUpdate()
    {
        rb.AddForce(Vector3.right * forwardPower, ForceMode.Force);
    }
   void OnCollisionEnter(Collision collision)
    {
        sum.SetActive(true);
    }
}
