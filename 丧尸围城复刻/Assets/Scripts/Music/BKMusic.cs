using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKMusic : MonoBehaviour
{
    public static BKMusic Instance { get; private set; }
    private AudioSource audioSource;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        Init();
        
    }


    private void Init()
    {
        ChangeMusicValue(GameDataManager.Instance.musicData.musicValue);
        ChangeMusicOpen(GameDataManager.Instance.musicData.musicOpen);
    }

    public void ChangeMusicValue(float value)
    {
        audioSource.volume = value;
    }
    public void ChangeMusicOpen(bool open)
    {
        audioSource.mute = !open;
    }


}
