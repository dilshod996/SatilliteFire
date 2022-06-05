using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    [SerializeField] float speedMyBall = 1f;
    [SerializeField] float speedSides = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, speedMyBall * Time.deltaTime);
        }
        TurningLeft();
        TurningRight();

        
    }
    void TurningLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Turnings(-speedSides);
        }
    }
    void TurningRight()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Turnings(speedSides);
        }
    }
    void Turnings(float xPosition)
    {
        transform.position = transform.position + new Vector3(xPosition * Time.deltaTime, 0, 0);
    }
}
