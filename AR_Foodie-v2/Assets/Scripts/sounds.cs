using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class sounds : MonoBehaviour
{
    public AudioClip sound;
   
    private Button button1 { get { return GetComponent<Button>(); } }

    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();

        source.clip = sound;
        source.playOnAwake = false;

        button1.onClick.AddListener(() => playSound());
    }

   
    public void playSound()
    {
        source.PlayOneShot(sound);
    }
}
