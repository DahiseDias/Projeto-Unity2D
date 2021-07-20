using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantas : MonoBehaviour
{
    public string resposta;
    public Animator animator;
    AudioSource som;

    
    void Start()
    {
        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("pocao")){
            animator.SetTrigger("colidiu");
            som.Play();
        }
    }
}

