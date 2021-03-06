//using System.Threading.Tasks.Dataflow;
using System.Threading;
//using System.Numerics;
//using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocao : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] ParticleSystem efeito;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(efeito, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
