using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryHiyokoBall : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit!!");
        Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得

        if (collision.gameObject.name == "CannonMuzzle" || collision.gameObject.name == "CannonBallPrefab(Clone)")
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}
