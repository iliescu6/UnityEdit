using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject slotGroup;
    List<GameObject> slots;
    // Start is called before the first frame update
    void Start()
    {
        slots = new List<GameObject>();
        foreach (Transform slot in slotGroup.transform)
        {
            slots.Add(slot.gameObject);
            Debug.Log("Slot:" + slot.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
