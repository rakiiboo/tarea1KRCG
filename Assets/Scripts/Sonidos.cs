using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
  public void PlaySonido(AudioClip clip){
        AudioSource source = gameObject.GetComponent<AudioSource>();
        source.PlayOneShot(clip);
    }
}
