﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRange = 5.5f;
    public float power = 1000f;
    public GameObject cannonBall;
    public Transform spawnPoint;
    public AudioClip sound1;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // while pause, don't move and shoot
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        transform.Translate(Input.GetAxisRaw(
            "Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position = new Vector2(Mathf.Clamp(
            transform.position.x, -moveableRange, moveableRange),
            transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject newBullet =
            Instantiate(cannonBall, spawnPoint.position, Quaternion.identity) as GameObject;
        newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
        audioSource.PlayOneShot(sound1);
    }
}
