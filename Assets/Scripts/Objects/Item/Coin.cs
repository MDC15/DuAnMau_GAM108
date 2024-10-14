using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tags;

public class Coin : MonoBehaviour
{
    public int Point;
    public Score score;

    private bool isCoined = false;
    #region Audio
    private AudioSource myAudioSource; //trinh phat am thanh

    [SerializeField]
    private AudioClip _myAudio; //file am thanh
    #endregion

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagConst.PLAYER_TAG) && !isCoined)
        {
            isCoined = true;
            myAudioSource.PlayOneShot(_myAudio);
            // score.AddScore(Point);
            // Instantiate explosion
            Destroy(gameObject, 0.2f);
        }
    }
}
