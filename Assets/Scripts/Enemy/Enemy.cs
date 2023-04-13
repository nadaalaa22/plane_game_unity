using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public float speed ;
   // private string BULLET_TAG = "Bullet";
    private Animator animator;
    [SerializeField] private AudioSource audioSource;


    private void Start()
    {   // a lot of way to make a private or serilaz
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Translate(Vector2.down  * speed* Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {

            // Die();
            audioSource.Play();
            Destroy(gameObject);
        }

    }


    private void Die()
    {
        animator.SetTrigger("Death");
        StartCoroutine("Death");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);

    }



}
