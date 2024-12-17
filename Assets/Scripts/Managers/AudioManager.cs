using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("music MX")]
    public AudioClip titleScreen_MX;
    public AudioClip wasteDump_MX;

    [Header ("Audio source")]
    [SerializeField] private AudioSource soundFXObject;

    [Header("Scene SFX")]
    public AudioClip robot_SFX;
    public AudioClip incinerator_SFX;
    public AudioClip flashlightOn_SFX;
    public AudioClip flashlightOff_SFX;
    public AudioClip itemInteract_SFX;
    public AudioClip dialogue_SFX;
    public AudioClip enteringRoom_SFX;
    public AudioClip exitingRoom_SFX;
    public AudioClip waterDrip_SFX;
    [Header ("Player movement SFX")]
    public AudioClip wallBump_SFX;
     public AudioClip takeDamage_SFX;
    public AudioClip[] playerWalk_SFX;


    [Header ("UI SFX")]
    public AudioClip UIButton_SFX; //click UI button
    public AudioClip openUI_SFX; //open or close inventory

    // we can add more of the ambient SFX here once we know what we have

    [Header ("Audio Mixers")]
    AudioMixer audioMixer;
    AudioSource AudioSource;
    public AudioMixerGroup musicMixer;
    public AudioMixerGroup SFXMixer;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else Instance = this;

    }
   
    //play sound clips. accessible in other scripts
    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        //spawn in game object
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        audioSource.outputAudioMixerGroup = SFXMixer; //output sound effects to SFX sound mixer
        //assign audioclip
        audioSource.clip = audioClip;
        //assign volume
        audioSource.volume = volume;
        //play sound
        audioSource.Play();
        //get length of clip
        float clipLength = audioSource.clip.length;
        //destroy game object
        Destroy(audioSource.gameObject, clipLength);
    }




//Play random sound clips while walking around
public void PlayRandomSoundFXClipWalking(AudioClip[] audioClip, Transform spawnTransform, float volume)
    {
        //assign audioclip index
        int rand = Random.Range(0, audioClip.Length);
        //spawn in game object
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);
        //assign audioclip
        audioSource.clip = audioClip[rand];
        //assign volume
        audioSource.volume = volume;
        //play sound
        audioSource.Play();
        //get length of clip
        float clipLength = audioSource.clip.length;
        //destroy game object
        Destroy(audioSource.gameObject, clipLength);
    }
    

}
