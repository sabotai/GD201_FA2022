using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivation : MonoBehaviour
{
    public GameObject enemyToActivate;
    public GameObject key;
    public bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey && enemyToActivate && !enemyToActivate.activeSelf){
            enemyToActivate.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider col){
        if (col.gameObject == key){
            hasKey = true;
            Destroy(key);
        }
    }
}
