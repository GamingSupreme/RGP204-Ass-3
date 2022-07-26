using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform TrapList;
    public GameObject Trap;

    public Transform ChildList;
    public GameObject Child;

    void PlaceTrap(Vector3 worldPos)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject placeTrap = Instantiate(Trap, worldPos, Quaternion.identity);
            placeTrap.transform.position += new Vector3(0, 0, 1);
            placeTrap.transform.SetParent(TrapList);
        }
    }
    
    void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        PlaceTrap(worldPosition);
    }
}
