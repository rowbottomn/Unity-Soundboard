using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
    public GameObject queue1;
    public GameObject queue2;
    public GameObject queue3;

    public TMPro.TMP_InputField time1;
    public TMPro.TMP_InputField time2;
    public TMPro.TMP_InputField time3;

    public Button set;
    public Button play;

    public float timerx;
    public int seconds;

    public int x1;
    public int x2;
    public int x3;

    public AudioSource a1;
    public AudioSource a2;
    public AudioSource a3;

    public bool playing;
    // Use this for initialization
    void Start () {
        a1 = queue1.GetComponent<AudioSource>();
        a2 = queue2.GetComponent<AudioSource>();
        a3 = queue3.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (playing)
        {

            a1 = queue1.GetComponent<AudioSource>();
            a2 = queue2.GetComponent<AudioSource>();
            a3 = queue3.GetComponent<AudioSource>();

            timerx += Time.deltaTime;
            seconds = (int)timerx % 60;
            if (seconds == x1)a1.Play();
            if (seconds == x2) a2.Play();
            if (seconds == x3) a3.Play();
        }
        
	}

    public void loopAll()
    {
        a1.loop = true;
        a2.loop = true;
        a3.loop = true;
    }

    public void setValues()
    {
        x1 = int.Parse(time1.text);
        x2 = int.Parse(time2.text);
        x3 = int.Parse(time3.text);
    }

    public void playAll()
    {
        playing = true;
    }
}
