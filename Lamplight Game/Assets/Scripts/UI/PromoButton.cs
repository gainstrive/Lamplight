using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromoButton : MonoBehaviour {

    public void OpenURL() {
        Application.OpenURL("http://google.com/");
        Debug.Log("Working");
    }
}
