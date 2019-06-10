using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchRotControl : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform parent;
    private float radius;

    public Vector2 rotInput;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform.parent.GetComponent<RectTransform>();
        radius = parent.sizeDelta.x / 2;
        rotInput = Vector2.zero;
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


        rotInput = this.transform.localPosition / radius;
        Debug.Log(rotInput.magnitude);
    }



    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.transform.localPosition = Vector3.zero;
        //rotInput = Vector2.zero;
    }
}
