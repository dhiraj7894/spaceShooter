using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class fireButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool pressed = false;
    Color32 c;
    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        GetComponent<Image>().color = new Color(1, 1, 1, 0.2f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        GetComponent<Image>().color = new Color(1, 1, 1, 0.3f);
    }
}
