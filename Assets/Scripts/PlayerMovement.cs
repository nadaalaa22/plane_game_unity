using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public float padding = 0.8f;
    float minX;
    float maxX;
    private string ENEMY_TAG = "Enemy";
    private Animator animator;
    
    void Start()
    {
        FindBoundaries();
        animator = GetComponent<Animator>();
    }

    void FindBoundaries ()
    {
        Camera cam = Camera.main;
        minX = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        maxX = cam.ViewportToWorldPoint(new Vector3(1,0, 0)).x - padding;
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
    }


    void PlayerMoveKeyboard()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float newXpos = Mathf.Clamp(transform.position.x + deltaX, minX, maxX);
        transform.position = new Vector2(newXpos, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Die();

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
