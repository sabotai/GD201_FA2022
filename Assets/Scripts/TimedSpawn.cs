using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    
    public float basicTimer = 7.25f;
    public float bossTimer = 10f;
    public GameObject basicSpawn, bossSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.timeSinceLevelLoad > basicTimer){
            //restartGame();
            Instantiate(basicSpawn, new Vector3(Random.Range(-5f, 5f),0f,0f), Quaternion.identity);
            basicTimer += Time.timeSinceLevelLoad;
        }
        if (Time.timeSinceLevelLoad > bossTimer){
            Instantiate(bossSpawn, new Vector3(Random.Range(-5f, 5f),0f,0f), Quaternion.identity);
            Destroy(this);

        }

    }
}
