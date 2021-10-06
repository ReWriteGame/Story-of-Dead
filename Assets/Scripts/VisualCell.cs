using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualCell : MonoBehaviour
{
    [SerializeField] private Text cellValue;
    [SerializeField] private Cell cell;

    private void Start()
    {
        cellValue = GetComponent<Text>();
        cell = GetComponentInParent<Cell>();

        cellValue.text = cell.Value + "";
    }
}
