using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    float moveSpeed = 10;
    float rotatingSpeed = 80;

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        
        transform.Translate(moveVertical* Time.deltaTime*moveSpeed*Vector3.forward);
        transform.Rotate(Vector3.up, moveHorizontal* Time.deltaTime* rotatingSpeed);
        

    }
}
