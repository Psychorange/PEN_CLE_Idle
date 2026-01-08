using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CursorManager : MonoBehaviour
{
    public RectTransform mouseTriggerBox;
    public RectTransform cursorMove;


    public void Update()
    {
        mouseTriggerBox.anchoredPosition = Input.mousePosition;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (other.CompareTag("Cursor"))
            {
                cursorMove.anchoredPosition = Input.mousePosition;
            }
        } 
    }
}
