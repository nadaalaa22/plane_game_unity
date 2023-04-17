using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    // to call the game over once 
    private bool dead;
    private SpriteRenderer spriteRend;
    private bool invulnerable;

    [SerializeField] private AudioSource AudioSource;
    
    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }
    public void TakeDamage(float _damage)
    {
       
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0) // player hurt
        {
           
            AudioSource.Play();
            //SoundManager.instance.PlaySound(hurtSound);
        }
        else // player dead 
        {
            if (!dead)
            {
                anim.SetTrigger("Death");

                AudioSource.Play();
                dead = true;
                StartCoroutine("Wait");
                //SoundManager.instance.PlaySound(deathSound);
            }
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.8f);

        if (SceneManager.GetActiveScene().name == "level 1")

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else if (SceneManager.GetActiveScene().name == "level 2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
