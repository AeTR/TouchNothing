using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public float maxRaycastDist = 1000f;

    private Transform _selection;
    private bool isMouseDragging = false;
    private Vector3 screenPosition;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        Ray camRay = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(camRay.origin, camRay.direction * maxRaycastDist, Color.green);

        RaycastHit hitObject;
        if (Physics.Raycast(camRay, out hitObject, maxRaycastDist))
        {

            var selection = hitObject.transform;
            Debug.Log(selection.name);
            if (Input.GetMouseButtonDown(0))
            {
                if (selection.CompareTag("Lever"))
                {
                //selection.Translate(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
                isMouseDragging = true;
                screenPosition = Camera.main.WorldToScreenPoint(selection.transform.position);
                offset = selection.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z)); 

                }
                else
                {
                    selection.SendMessage("Interact");
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                isMouseDragging = false;
            }
            if (isMouseDragging)
            {
                Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z);
                Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offset;
                selection.transform.position = currentPosition;

            }

            _selection = selection;

        }
    }
}
