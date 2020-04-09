using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public SuperBird bird;
    private void Awake()
    {
        bird = GameObject.FindObjectOfType<SuperBird>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bird.gameObject.transform.position.x,0,-5f);
    }
}
