using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("MX")]
    public AudioClip titleScreen_MX;
    public AudioClip wasteDump_MX;

    [Header("SFX")]
    public AudioClip robot_SFX;
    public AudioClip incinerator_SFX;
    public AudioClip wallBump_SFX;
    public AudioClip flashlightOn_SFX;
    public AudioClip flashlightOff_SFX;
    public AudioClip itemInteract_SFX;
    public AudioClip dialogue_SFX;
    public AudioClip takeDamage_SFX;
    public AudioClip enteringRoom_SFX;
    public AudioClip exitingRoom_SFX;
    public AudioClip waterDrip_SFX;
    // we can add more of the ambient SFX here once we know what we have

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
