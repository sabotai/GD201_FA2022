using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollisionRespawn : MonoBehaviour
{
    [Tooltip("Set any death/respawn hazards to be tagged with this. Make sure their colliders are marked as triggers.")]
    public string hazardTag = "hazard";
    [Tooltip("Alternatively, assign a single death/respawn hazard this way. Make sure its colliders is marked as a trigger.")]
    public GameObject singleHazard;
    [Tooltip("Create an empty gameobject, position it where you want to respawn and then assign it here.")]
    public Transform respawnLocation;
    [Tooltip("Assign this to whatever thing you want to respawn.")]
    public Transform objectToRespawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if (col.CompareTag(hazardTag) || col.gameObject == singleHazard){
            objectToRespawn.position = respawnLocation.position;
        }
    }

}
