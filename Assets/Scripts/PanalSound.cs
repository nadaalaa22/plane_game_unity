using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanalSound : MonoBehaviour
{
    [SerializeField] private AudioSource m_AudioSource;

    public void Start()
    {
        m_AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
