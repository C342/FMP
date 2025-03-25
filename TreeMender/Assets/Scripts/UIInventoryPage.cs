//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Jobs;

//namespace Inventory

//{
//    public class UIInventoryPage : MonoBehaviour
//    {
//        [SerializeField]
//        private UIInventoryItem itemPrefab;

//        [SerializeField]
//        private RectTransform contentPanel;

//        List<UIInventoryItem> listofUIItems = new List<UIInventoryItem>();

//        public void InitializeInventoryUI(int inventorysize)
//        {
//            for (int i = 0; i < inventorysize; i++)
//            {
//                UIInventoryItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
//                uiItem.transform.SetParent(contentPanel);
//                listofUIItems.Add(uiItem);
//            }
//        }

//        internal void Hide()
//        {
//            throw new NotImplementedException();
//        }

//        internal void Show()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public void Show()
//    {
//        gameObject.SetActive(true);
//    }

//    public void Hide()
//    {
//        gameObject.SetActive(false);
//    }
//}