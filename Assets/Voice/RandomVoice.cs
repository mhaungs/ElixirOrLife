using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomVoice : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    public AudioSource horns;
    float timer = 0;
    public float timeTilNextSpawn = 20f;
    public GameObject tooltip;
    public bool startover;
    public bool noRepeat;
    void Start()
    {
        noRepeat = true;
       startover = false;
        tooltip.SetActive(false);
        timer = 0;
        source = GetComponent<AudioSource>();
        Invoke("startvoice", 1);

    }

    private void Update()
    {
        timer += Time.deltaTime;
        spawn();

        if (!source.isPlaying && startover == true && noRepeat == true)
        {
            if(Time.timeScale ==1)
            {
                horns.Play();
            }
         
            tooltip.SetActive(true);
            Invoke("off", 5);
            noRepeat = false;
        }
    }
    void startvoice()
    {
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
            startover = true;


        }
    }
    
    void off()
    {
        tooltip.SetActive(false);
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