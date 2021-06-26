using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BallController : MonoBehaviour
{
    private Rigidbody rigidBody;
    private float m_MovePower = 5; 
    private Vector3 move;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rigidBody == null)
            return;
        
        float h = CrossPlatformInputManager.GetAxis("HorizontalBall");
        float v = CrossPlatformInputManager.GetAxis("VerticalBall");
        
        move = (v*Vector3.forward + h*Vector3.right).normalized;
        
        rigidBody.AddTorque(new Vector3(move.z, 0, -move.x)*m_MovePower);
    }
}
