using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField] Text scoree; 
    level levele;

    // Start is called before the first frame update
    void Start()
    {
        levele = FindAnyObjectByType<level>();

        
    }

    // Update is called once per frame
    void Update()
    {
       scoree.text = levele.getScore();
    }
}
