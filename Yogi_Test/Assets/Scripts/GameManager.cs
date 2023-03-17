using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {
    //Player Constants
    public static float SCROLL_DOWN_SPEED = 4f, DEATH_ZONE_WIDTH = 1;
    public static Vector2 screenBounds;
    public GameObject ButtonPanel,E1,E2;
    public static GameManager instance;
    #region Non Static Copies to tweak them from Unity OnInspector 
    
    //[SerializeField] private float _DEATH_ZONE_WIDTH = 1;
    [SerializeField] private float _SCROLL_DOWN_SPEED = 0.25f;
    #endregion

    void OnEnable() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log("Screenbounds" + screenBounds.ToString());
    }

    void Update() {
        SCROLL_DOWN_SPEED = _SCROLL_DOWN_SPEED;
    }

    public void StartGame()
    {

        ButtonPanel.SetActive(false);
        E1.SetActive(true);
        E2.SetActive(true); 
    }
  
    public void endgame()
    {
        ButtonPanel.SetActive(true);
    }

}
