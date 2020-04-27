using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject menuAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void MainMenuOut()
    {
        menuAnimator = GameObject.Find("Main_Menu");
        menuAnimator.GetComponent<Animator>().Play("Main_Menu_Out", 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
