using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour

{
    Vector2 differnce; 
    public Paddel paddel;
    bool hasStarted = false; 
    // Start is called before the first frame update
    void Start()
    {
        differnce = transform.position - paddel.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted== false) { 
        LockBall();
        }
        launchBall();
    }
    void launchBall()
    {
        if (Input.GetMouseButtonDown(0)) { 
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f,15f);
        }
    }
    void LockBall()
    {


        Vector2 posPaddel = new Vector2(paddel.transform.position.x, paddel.transform.position.y);
        transform.position = posPaddel + differnce;



    }


}
