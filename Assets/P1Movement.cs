using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class P1Movement : MonoBehaviour
{
    public Rigidbody2D arm;
    public Rigidbody2D lLeg;
    public Rigidbody2D rLeg;

    Vector3 moveLeft = new Vector3(-1f, 0.2f, 0f);
    Vector3 moveRight = new Vector3(1f, 0.2f, 0f);
    Vector3 moveUp = new Vector3(0f, 1f, 0f);
   
    [SerializeField] float movePower = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            lLeg.AddForce(moveLeft * movePower, ForceMode2D.Impulse);
            rLeg.AddForce(moveRight * movePower * 0.5f, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rLeg.AddForce(moveLeft * movePower * 0.5f, ForceMode2D.Impulse);
            lLeg.AddForce(moveRight * movePower, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            arm.AddForce(moveUp * movePower, ForceMode2D.Impulse);
        }
    }
}
