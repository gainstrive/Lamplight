using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowSound : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip AudioClip;
    private bool OnCooldown;
    private void OnMouseEnter()
    {
        Debug.Log("MOUSEOVER");
        if (!OnCooldown)
        {
            AudioSource.PlayOneShot(AudioClip);
            StartCoroutine("SoundCooldown");
        }
        else
        {
            return;
        }
    }

    public IEnumerator SoundCooldown()
    {
        OnCooldown = true;
        yield return new WaitForSeconds(1);
        OnCooldown = false;
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
