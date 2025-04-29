using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Tilemaps;

public class ToolTipManager : MonoBehaviour
{
    public static ToolTipManager _instance;
    public TextMeshProUGUI text;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetAndShowToolTip(string message)
    {
        gameObject.SetActive(true);
        text.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        text.text = string.Empty;
    }
}