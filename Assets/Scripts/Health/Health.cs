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
    //[SerializeField] private AudioSource AudioSource2;
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
           
            //StartCoroutine(Invunerability());
            AudioSource.Play();
            //SoundManager.instance.PlaySound(hurtSound);
        }
        else // player dead 
        {
            if (!dead)
            {
                anim.SetTrigger("Death");

                //Deactivate all attached component classes
                //foreach (Behaviour component in components)
                //    component.enabled = false;
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
    //private IEnumerator Invunerability()
    //{
    //    invulnerable = true;
    //    Physics2D.IgnoreLayerCollision(10, 11, true);
    //    for (int i = 0; i < numberOfFlashes; i++)
    //    {
    //        spriteRend.color = new Color(1, 0, 0, 0.5f);
    //        yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
    //        spriteRend.color = Color.white;
    //        yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
    //    }
    //    Physics2D.IgnoreLayerCollision(10, 11, false);
    //    invulnerable = false;
    //}
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.8f);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
