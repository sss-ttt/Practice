
using UnityEngine;
[CreateAssetMenu(menuName = "Create AudioPackData")]
[System.Serializable]
public class data_audiopack : ScriptableObject
{
    public string NameTag; 
    public AudioClip[] clips;

}

