using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private List<Item> items = new List<Item>();

    public ItemTemplate[] itemTemplates;


    public ItemType filterType;

    void Start()
    {

        foreach (ItemTemplate template in itemTemplates)
        {
            Item newItem = template.CreateInstance();
            items.Add(newItem);
            Debug.Log(newItem.Describe());
        }
    }


    public List<Item> GetItemsByType(ItemType type)
    {
        List<Item> filtered = new List<Item>();
        foreach (Item item in items)
        {
            if (item.itemType == type)
            {
                filtered.Add(item);
            }
        }
        return filtered;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            List<Item> filteredItems = GetItemsByType(filterType);
            foreach (Item fi in filteredItems)
            {
                Debug.Log(fi.Describe());
            }

        }
    }
}
