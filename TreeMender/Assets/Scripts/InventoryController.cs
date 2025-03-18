using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private ItemDictionary itemDictionary;

    public GameObject inventoryPanel;
    public GameObject slotPrefab;
    public int slotCount;
    public GameObject[] itemPrefabs;

    void Start()
    {
        itemDictionary = FindObjectOfType<ItemDictionary>();
        //itemDictionary = FindObjectOfType<ItemDragHandler>();

        for (int i = 0; i < slotCount; i++)
        {
            Slot slot = Instantiate(slotPrefab, inventoryPanel.transform).GetComponent<Slot>();
            if (i < itemPrefabs.Length)
            {
                GameObject item = Instantiate(itemPrefabs[i], slot.transform);
                item.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = item;
            }
        }
    }

    public List<InventorySaveData> GetInventoryItems()
    {
        List<InventorySaveData> invData = new List<InventorySaveData>();
        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            Slot slot = slotTransform.GetComponent<Slot>();
            if (slot.currentItem != null)
            {
                Item item = slot.currentItem.GetComponent<Item>();
                invData.Add(new InventorySaveData { itemID = item.ID, SlotIndex = slotTransform.GetSiblingIndex() });
            }
        }
        return invData;

    }

    public void SetInventoryItems(List<InventorySaveData>)
    {
        foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < slotCount; i++)
        {
            Instantiate(slotPrefab, inventoryPanel.transform);
        }

        //foreach (InventorySaveData data in InventorySaveData)
        //{
        //    if (data.SlotIndex < slotCount)
        //    {
        //        Slot slot = inventoryPanel.transform.GetChild(data.SlotIndex).GetComponent<Slot>();
        //        GameObject itemPrefab = itemDictionary.GetItemPrefab(data.itemID);
        //        if (itemPrefab != null)
        //        {
        //            GameObject item = Instantiate(itemPrefab, slot.transform);
        //            item.GetComponent<RectTransform>.anchoredPosition = Vector2.zero;
        //            slot.currentItem = item;
        //        }
        //    }
        //}
    }

    public bool AddItem(GameObject itemPrefab)
    {
        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            Slot slot = GetComponent<Slot>();
            if (slot != null && slot.currentItem == null)
            {
                GameObject newItem = Instantiate(itemPrefab, slotTransform);
                newItem.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = newItem;
                return true;
            }
        }
        Debug.Log("Inventory is full!");
        return false;
    }
}