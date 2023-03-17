using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AstroSpawnerScript : MonoBehaviour {
    [SerializeField] private GameObject meteor;
    [SerializeField] private float delay;
    float timeElapsed = 0;
    private void Start()
    {
        
    }
    void Update()
    {

        timeElapsed += Time.deltaTime;
        if (timeElapsed >= delay)
        {
            spawnMeteor();
            timeElapsed = 0;
         
        }
    }
    
    void spawnMeteor()
    {
        GameObject g = Instantiate(meteor,
        new Vector3(Random.Range(GameManager.screenBounds.x, -GameManager.screenBounds.x)
        , GameManager.screenBounds.y, 0), Quaternion.identity) as GameObject;
    }
}
