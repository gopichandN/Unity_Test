using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    [SerializeField] private int speed;
    [SerializeField] private GameObject player;
    PlayerScript ps;
    void OnEnable() {
        ps = player.GetComponent<PlayerScript>();
    }
    void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > GameManager.screenBounds.y) {
            ps.returnToPool(this.gameObject);
        }

    }

    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.GetComponent<AstroScript>() != null) {
            Destroy(other.gameObject);
            
            ScoreCount.i += 10;

        }
    }
}
