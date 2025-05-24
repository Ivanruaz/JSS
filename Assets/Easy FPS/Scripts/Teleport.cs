using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
