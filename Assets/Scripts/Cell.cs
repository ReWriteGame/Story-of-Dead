using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private int value = 0;
    [SerializeField] private Vector2Int rangeValue;
    [SerializeField] public int ID = 0;

    public int Value { get => value; private set => this.value = value; }

    private void Awake()
    {
        setRandomValue();
    }
    private void setRandomValue()
    {
        value = Random.Range(rangeValue.x, rangeValue.y);
    }
}
