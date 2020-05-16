using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class EnemyMoviment : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    int damage = 0;
    public int _EnemyLive = 1;
   


    private void Start()
    {
       // Vector3 posicion = new Vector3(0, 5, 0);
       // Instantiate(Enemy, posicion, Quaternion.identity);
       // randomSpawn();
    }

    void Update()
    {
        transform.Translate(0, -_speed * Time.deltaTime, 0);
        randomSpawn();
    }

    void randomSpawn()
    {
       
            Vector3 position = new Vector3(Random.Range(-6, 6), 6, 0);
            if (transform.position.y < -4.87f)
            {
                //transform.position = position;
                Destroy(this.gameObject);
            }
        
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.transform.name == "Player")
        {
            PlayerMoviment player = other.transform.GetComponent<PlayerMoviment>();
            
            if(player != null)
            {
              
                player.damage();
            }
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Laser")
        {
            damage = damage + 1;
            Destroy(other.gameObject);
           
            if (damage == _EnemyLive) {

                Destroy(this.gameObject);
                

            }
            
        }

    }

 
}
