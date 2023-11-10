using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel : MonoBehaviour
{
    public float Unit; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MousePostion = (Input.mousePosition.x/Screen.width * Unit);
        Vector2 Padel = new Vector2(transform.position.y, transform.position.y);
        Padel.x = Mathf.Clamp(MousePostion, (float)-6.70, (float)6.70);
        transform.position = Padel;


        
    }
}
