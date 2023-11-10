using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    public AudioClip breaksound;
    level leevel;
    private void Start()
    {
        leevel = FindObjectOfType<level>();
        leevel.countblocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breaksound, Camera.main.transform.position);
        Destroy(gameObject);
        leevel.countBreakedblocks();

    }
}
