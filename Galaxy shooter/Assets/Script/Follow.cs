using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public Transform player;
    public Vector3 distancia;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (player.position + distancia);
    }
}
