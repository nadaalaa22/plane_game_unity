using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
    public GameObject playerBullet;
    private AudioSource audioSource;
    public Transform spawner1;
    public Transform spawner2;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(playerBullet, spawner1.position, Quaternion.identity);
            Instantiate(playerBullet , spawner2.position, Quaternion.identity);

        }

    }
}
