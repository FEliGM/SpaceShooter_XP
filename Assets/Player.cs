using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float maxHP = 100f;
    public float timeBetweenShoots = 0.5f;
    public GameObject bulletPrefab;
    public GameObject DeathParticlePrefab;
    public Transform bulletOrigin;
    public Text hpText;
    public AudioClip shootAudioClip;
    public AudioClip explosionAudioClip;

    private float currentHP;
    private float timeOfLastShoot;

    private void Start()
    {
        currentHP = maxHP;
        hpText.text = "HP: " + currentHP;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > timeOfLastShoot + timeBetweenShoots)
                Shoot();
        }
    }

    public void Damage(float amount)
    {
        currentHP -= amount;
        hpText.text = "HP: " + currentHP;

        if(currentHP <= 0f)
        {
            Dead();
        }
    }


    private void Shoot()
    {
        Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
        timeOfLastShoot = Time.time;
        AudioSource.PlayClipAtPoint(shootAudioClip, transform.position, 0.5f);
    }

    private void Dead() 
    {
        AudioSource.PlayClipAtPoint(explosionAudioClip, transform.position, 5f);

        GameObject particles = Instantiate(DeathParticlePrefab, transform.position, transform.rotation);

        FindObjectOfType<GameManager>().GameOver();

        Destroy(this.gameObject);
    }
}
