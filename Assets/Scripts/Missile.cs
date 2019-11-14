using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Rigidbody2D rb;
    private int[] navigation = { -1, 1, 1, -1, 1, -1, 1, -1, -1, -1 };
    private float currentTime = 1;
    private float targetTime = 1;
    private int position = 0;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= targetTime)
        {
            rb.velocity = new Vector2(navigation[position], 1);
            position++;
            currentTime = 0;
            if (position >= navigation.Length) position = 0;

        }
        
    }
}
