using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldMonster : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 배틀 진입.
            Debug.Log(other.name);
        }
    }
}
