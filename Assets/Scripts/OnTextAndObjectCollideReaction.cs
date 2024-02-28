

using UnityEngine;

public class OnTextAndObjectCollideReactionScript : MonoBehaviour
{


    public AudioSource audioSource;
    public AudioClip correctClip;
    public AudioClip wrongClip;
    public float volume = 0.5f;

    void start()
    {

    }

    public void playCorrectSound()
    {
        audioSource.PlayOneShot(correctClip, volume);

    }

    public void playWrongSound()
    {
        audioSource.PlayOneShot(wrongClip, volume);

    }
}
