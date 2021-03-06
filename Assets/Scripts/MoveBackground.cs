﻿using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;
    [SerializeField]
    private float offset;

    private Vector2 startPosition;
    private float newXPosition;
    private void Start()
    {
        startPosition = transform.position;
    }

    //parallax when graphics moove
    private void Update()
    {
        newXPosition = Mathf.Repeat(Time.time * -moveSpeed, offset);
        transform.position = startPosition + Vector2.right * newXPosition;
    }
}
