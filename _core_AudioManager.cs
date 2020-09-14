using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class _core_AudioManager : MonoBehaviour
{
    static public _core_AudioManager AudioManager;
    public static AudioSource[] AudioSources;
    void Awake()
    {
        if (AudioManager == null)
        {
            AudioManager = this;
            DontDestroyOnLoad(gameObject);
            AudioSources = GetComponents<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public List<data_audiopack> audiopacks;
    public void PlaySound(string AudioPackTag)
    {
        foreach (data_audiopack audiopack in audiopacks)
        {
            if (audiopack.NameTag == AudioPackTag)
            {
                AudioSources[0].PlayOneShot(audiopack.clips[Random.Range(0, audiopack.clips.Length)]);
                return;
            }
        }
    }
}
