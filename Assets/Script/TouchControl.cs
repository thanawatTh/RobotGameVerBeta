using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControl : MonoBehaviour,IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform parent;
    private float radius;
    public Vector2 joyInput;
    public Vector2 rotationInput;


    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform.parent.GetComponent<RectTransform>();
        radius = parent.sizeDelta.x / 4;
        joyInput = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;

        if (this.transform.localPosition.magnitude > radius)
        {
            this.transform.localPosition = this.transform.localPosition.normalized * radius;

        }

        joyInput = this.transform.localPosition / radius;
        rotationInput = this.transform.localPosition / radius;

        Debug.Log(joyInput.magnitude);
    }



    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
       this.transform.localPosition = Vector3.zero;
        joyInput = Vector2.zero;
    }
}
