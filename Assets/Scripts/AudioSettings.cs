using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioSettings : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public Button muteButton;
    public Button playButton;

    public Slider volumeSlider;
    public Slider scrubberSlider;

    public TMPro.TMP_InputField fadeInText;
    public TMPro.TMP_InputField fadeOutText;
    public TMPro.TMP_InputField startText;
    public TMPro.TMP_InputField endText;

    public bool mute = false;
    public bool play = false;
    public bool looping = false;

    public float volume = 1;


    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        getPosition();
    }

    public void muting()
    {
        if (!mute)
        {
            source.volume = 0;
            mute = true;
        }
        else if (mute)
        {
            source.volume = volume;
            mute = false;
        }
    }

    public void playPause()
    {
        if (!play)
        {
            source.Play();
            play = true;
        }
        else if (play)
        {
            source.Pause();
            play = false;
        }
    }

    public void setVolume()
    {
        source.volume = volumeSlider.value;
    }

    public void getPosition()
    {
        scrubberSlider.value = source.time / source.clip.length;
    }

    public void ff()
    {
        source.time = source.time + 1;
    }

    public void rr()
    {
        source.time = source.time - 1;
    }

    public void loop()
    {
        if (!looping)
        {
            source.loop = true;
            looping = true;
        }
        else if (looping)
        {
            source.loop = false;
            looping = false;
        }
    }

    public void fadeManager()
    {
        if (fadeOutText.text != "")
        {
            if ((int)source.time == int.Parse(fadeOutText.text))
            {
                fadeOut();
            }
        }
    }

    public void fadeIn()
    {
        if (source.volume < 1)
        {
            source.volume += (float)0.1 * Time.deltaTime;
        }
    }

    public void fadeOut()
    {
        if (source.volume > 0)
        {
            source.volume -= (float)0.1 * Time.deltaTime;
        }
    }
}
