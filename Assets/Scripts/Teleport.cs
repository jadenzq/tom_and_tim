using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject player;
    public GameObject exit;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D (Collider2D collision) {
        
        if (collision.tag == "Player") {
            player.transform.position = new Vector2(exit.transform.position.x, player.transform.position.y);
        }
    }
}
