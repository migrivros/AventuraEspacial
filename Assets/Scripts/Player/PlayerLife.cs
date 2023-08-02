using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    public GameObject gameOverScreen;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource damageSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap") || collision.gameObject.CompareTag("WeakEnemy") || collision.gameObject.CompareTag("MediumEnemy")
            || collision.gameObject.CompareTag("StrongEnemy") || collision.gameObject.CompareTag("KnightBoss") || collision.gameObject.CompareTag("NinjaBoss")
            || collision.gameObject.CompareTag("WitchBoss"))
        {
            HealthManager.playerHealth--;
            if(HealthManager.playerHealth <= 0)
            {
                PlayerManager.isGameOver = true;
                gameOverScreen.SetActive(false);
                Die();
            }
            else
            {
                damageSoundEffect.Play();
                StartCoroutine(GetHurt());
            }
            
        }
        if(collision.gameObject.CompareTag("LetalTrap"))
        {
            HealthManager.playerHealth = HealthManager.playerHealth - 3;
            damageSoundEffect.Play();
            if(HealthManager.playerHealth <= 0)
            {
                PlayerManager.isGameOver = true;
                gameOverScreen.SetActive(false);
                Die();
            }
            
        }
    }

    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6,8);
        GetComponent<Animator>().SetLayerWeight(1,1);
        yield return new WaitForSeconds(3);
        GetComponent<Animator>().SetLayerWeight(1,0);
        Physics2D.IgnoreLayerCollision(6,8, false);
    }

    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
    }

    public void RestartLevel()
    {
        ItemCollector.cherries = Checkpoint.savedCherries;
        ItemCollector.oranges = Checkpoint.savedOranges;
        ItemCollector.apples = Checkpoint.savedApples;
        ItemCollector.melons = Checkpoint.savedMelons;
        ItemCollector.coins = Checkpoint.savedCoins;
        ItemCollector.gasolines = Checkpoint.savedgGasolines;
        ItemCollector.maps = Checkpoint.savedMaps;
        ItemCollector.keys = Checkpoint.savedKeys;

        if(PlayerManager.lastCheckPoint == new Vector2(-239, 1))
        {
            GreenPigQuest2.complete = false;
            BatQuest3.complete = false;
            KnightQuest3.complete = false;
            RhinoQuest5.complete = false;
            GhostQuest6.complete = false;
            NinjaQuest6.complete = false;
            TrunkQuest7.complete = false;
            WitchQuest9.complete = false;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
