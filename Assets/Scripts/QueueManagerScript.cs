using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueManagerScript : MonoBehaviour {

    public GameObject[] SoundQueues;
    public GameObject SoundQueuePrefab;
    int CurrentQueue;
    
	// Use this for initialization
	void Start () {
        CurrentQueue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowNewQueue(AudioClip audio)
    {
       
       if(CurrentQueue < 3) { 
            //set queue 0 to enabled and pass in audio
            SoundQueues[CurrentQueue].gameObject.SetActive(true);
            //SoundQueues[CurrentQueue].GetComponent<AudioClip>();
            SoundQueues[CurrentQueue].GetComponent<AudioSettings>().clip = audio;
            print(CurrentQueue);
            CurrentQueue++;

        }
    } 
}
