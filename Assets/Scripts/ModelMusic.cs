using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMusic : MonoBehaviour
{
    public GameObject audio;
    // Start is called before the first frame update
    public void ActivateMusic() 
    {
        audio.GetComponent<AudioSource>().enabled = true;
    }
    public void DeactivateMusic()
    {
        audio.GetComponent<AudioSource>().enabled = false;
    }
    // Update is called once per frame

}
