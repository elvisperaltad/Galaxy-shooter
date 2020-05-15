using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform Enemy;
    public float EnmySpeed = 4f;
    public float SpawnCoolDown = 10f;
    private float Spawn1 = -1f;
    [SerializeField]
    public GameObject _EnemyConteiner;
    private bool _stopSpawn = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();

    }

    void Spawner()
    {
        Vector3 position = new Vector3(Random.Range(-6, 6), 6, 0);
        if (_stopSpawn == false)
        {
            if (Time.time > Spawn1)
            {
                Spawn1 = Time.time + SpawnCoolDown;

                var newEnemy = Instantiate(Enemy, position, Quaternion.identity);
                newEnemy.transform.parent = _EnemyConteiner.transform;
            }
        }
    }
    public void onPLayerDeath()
    {
        _stopSpawn = true;
    }
}
