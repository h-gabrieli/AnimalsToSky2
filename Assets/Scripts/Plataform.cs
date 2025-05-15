using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    [SerializeField] private Transform _posA, _posB;
    Vector3 targetPos;
    public float speed;

    
    void Start()
    {
        targetPos = _posB.position;
    }

    
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = this.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = null;

        }
    }
}