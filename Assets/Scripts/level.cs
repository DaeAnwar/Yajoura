using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class level : MonoBehaviour
{
    [SerializeField] int blockss;
    [SerializeField] string sceneName;
    public int score = 0;
  
    public void countblocks()
        {
  blockss++ ; 
        }

    public string getScore()
    {
        return ("Score = " + score);

    }
    public void countBreakedblocks()
    {
                   blockss--;
        score = score + 10; 

        if (blockss <= 0)
        {
            SceneManager.LoadScene(sceneName);

        }

    }


}
