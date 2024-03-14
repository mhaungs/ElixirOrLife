using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class VisibleBoss : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Crystals: " + num;
    }

    public void increase()
    {
        num +=1;
    }
}
