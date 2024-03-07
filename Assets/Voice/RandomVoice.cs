using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomVoice : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    float timer = 0;
    public float timeTilNextSpawn = 20f;
    void Start()
    {
         timer = 0;
        source = GetComponent<AudioSource>();
        Invoke("startvoice", 1);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        spawn();

    }
    void startvoice()
    {
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
        }
    }
    void spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
            timeTilNextSpawn = Random.Range(20f, 25f);
            timer = 0;
        }
    }
}