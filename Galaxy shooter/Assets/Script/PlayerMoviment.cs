using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    [SerializeField]
    private GameObject prefab;
    
    void Start()
    {
        transform.position = new Vector3 (0, -4.899429f, 0);    
    }

    // Update is called once per frame
    void Update()
    {
        movementPlayer();
        laserPrefab();

        
    }

    void laserPrefab()
    {
        Vector3 posicion = new Vector3(0, 1, 0);
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
            Instantiate(prefab, transform.position + posicion , Quaternion.identity);
      //  }
        
    }

    void movementPlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direccion * speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.899429f, 5));

        if (transform.position.x > 10.11827)
        {
            transform.position = new Vector3(-11.17799f, transform.position.y, 0);

        }
        else if (transform.position.x < -11.17799)
        {
            transform.position = new Vector3(10.11827f, transform.position.y, 0);
        }
    }
}
