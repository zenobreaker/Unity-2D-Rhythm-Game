﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBehaviour : MonoBehaviour
{
    public int noteType; 

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector3.down * GameManager.instance.noteSpeed); 
    }
}
