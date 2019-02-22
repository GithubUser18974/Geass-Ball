using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundGame : MonoBehaviour {
    [SerializeField]
    private AudioClip mBG;
    [SerializeField]
    private AudioClip mBG1;
    [SerializeField]
    private AudioClip mBG2;
    [SerializeField]
    private AudioClip mBG3;
    [SerializeField]
    private AudioClip mBG4;
    [SerializeField]
    private AudioSource mBGAudioSource;
    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetString("music") == "on")
        {
            switch (PlayerPrefs.GetString("bgsong"))
            {
                case "s": { mBGAudioSource.clip = mBG; mBGAudioSource.Play(); break; }
                case "s1": { mBGAudioSource.clip = mBG1; mBGAudioSource.Play(); break; }
                case "s2": { mBGAudioSource.clip = mBG2; mBGAudioSource.Play(); break; }
                case "s3": { mBGAudioSource.clip = mBG3; mBGAudioSource.Play(); break; }
                case "s4": { mBGAudioSource.clip = mBG4; mBGAudioSource.Play(); break; }


            }
        }
    }
	
}
