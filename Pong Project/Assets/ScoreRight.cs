using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreRight : MonoBehaviour
{
    public int scoreRight = 0;
    public AudioClip scoreSound;
    public AudioClip pointSound;
    public TextMeshProUGUI scoreTextLeft;
    void Start()
    {
        
    }
    
    void Update()
    {
        // UnityEngine.Debug.Log("The Right Score is " + scoreRight);
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        // UnityEngine.Debug.Log("Collider is working ");
        if (other.gameObject.tag == "Score Right") 
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = scoreSound;
            audioSource.Play();
            scoreRight ++;
            UnityEngine.Debug.Log("The Right Score is " + scoreRight);
            scoreTextLeft.text = "" + scoreRight;
            if ((scoreRight % 5) == 0)
            {
                scoreTextLeft.text = "Winner!";
                audioSource.clip = pointSound;
                audioSource.Play();
                
            }
        }
        
    }
    
 
}
