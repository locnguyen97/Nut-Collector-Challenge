using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TouchPoint : MonoBehaviour
{

    [SerializeField] private float scaleTo = 1.6f,scaleNho = 1.5f;
    public int id;
    [SerializeField] private List<Sprite> listWt;

    private bool isSelected = false;

    private void OnEnable()
    {
        var it = listWt[Random.Range(0, listWt.Count)];
        GetComponent<SpriteRenderer>().sprite = it;
        id = listWt.IndexOf(it);

    }

    public void SetCollected()
    {
        if(isSelected) return;
        isSelected = true;
        transform.localScale = Vector3.one*scaleTo;
        GetComponent<BoxCollider2D>().enabled = false;
    }
    public void SetUnCollected()
    {
        isSelected = false;
        transform.localScale = Vector3.one*scaleNho;
        GetComponent<BoxCollider2D>().enabled = true;
    }
}