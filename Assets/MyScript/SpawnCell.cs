using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCell : MonoBehaviour
{
    public GameObject[] Cells;
 
    void Start()
    {
        NewCell();
    }

    public void NewCell()
    {
        Instantiate(Cells[Random.Range(0, Cells.Length)], transform.position, Quaternion.identity);
    }
}
