using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour
{
    public NoteHolder noteHolder;
    public float playSpeedStressed;
    public float playSpeedRelaxed;
    public float playSpeedUberStress;
    public TextMeshProUGUI score;
    public int playerScore;
    public AudioSource[] badSounds;
    public AudioSource[] goodSounds;
    public bool isAnySoundPlaying = false;
    public bool doingWell;

    public AudioSource currentSound;

    private bool isStressedCoroutineRunning = false;
    private bool isRelaxedCoroutineRunning = false;

    void Start()
    {
        playSpeedRelaxed = 2f;
        playSpeedStressed = 4f;
        playSpeedUberStress = 8f;
    }

    void Update()
    {
        // Display score
        score.text = playerScore.ToString();

        if(playerScore > 30)
        {
            noteHolder.bpm = playSpeedUberStress;
        }

        if (playerScore > 10 && playerScore < 30)
        {
            doingWell = true;
        }

        if (doingWell && !isStressedCoroutineRunning)
        {
            StopAllCoroutines(); // Stop any other coroutines
            isRelaxedCoroutineRunning = false;
            StartCoroutine(PlayStressed());
        }
        else if (!doingWell && !isRelaxedCoroutineRunning)
        {
            StopAllCoroutines(); // Stop any other coroutines
            isStressedCoroutineRunning = false;
            StartCoroutine(PlayWell());
        }

        // Ensure playerScore doesn't go below 0
        if (playerScore <= 0)
        {
            playerScore = Random.Range(0, 2);
        }
    }

    IEnumerator PlayStressed()
    {
        isStressedCoroutineRunning = true;
        noteHolder.bpm = playSpeedStressed;
        Debug.Log("Stressed");

        if (!isAnySoundPlaying)
        {
            currentSound = badSounds[Random.Range(0, badSounds.Length)];
            currentSound.Play();
            isAnySoundPlaying = true;
        }

        yield return new WaitWhile(() => currentSound.isPlaying);
        yield return new WaitForSeconds(3f);
        isAnySoundPlaying = false;
        isStressedCoroutineRunning = false; // Allow this coroutine to run again if needed
    }

    IEnumerator PlayWell()
    {
        isRelaxedCoroutineRunning = true;
        noteHolder.bpm = playSpeedRelaxed;
        Debug.Log("Not Stressed!");

        if (!isAnySoundPlaying)
        {
            currentSound = goodSounds[Random.Range(0, goodSounds.Length)];
            currentSound.Play();
            isAnySoundPlaying = true;
        }

        yield return new WaitWhile(() => currentSound.isPlaying);
        yield return new WaitForSeconds(3f);
        isAnySoundPlaying = false;
        isRelaxedCoroutineRunning = false; // Allow this coroutine to run again if needed
    }
}
