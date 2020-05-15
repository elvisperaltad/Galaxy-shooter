using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LaserMoviment : MonoBehaviour
{
    // Start is called before the first frame update
   // public Transform player;
    private float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed * Time.deltaTime,0);

    }
}
