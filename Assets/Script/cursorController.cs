using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorController : MonoBehaviour
{
    public Texture2D cursor;

    private Controls controls;

    private Camera mainCamera;


    private void Awake()
    {
        controls = new Controls();

        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    private void ChangeCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }
    // Start is called before the first frame update
    void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => PerformedClick();

    }


    private void StartedClick()
    {

    }

    private void PerformedClick()
    {
        DetectObject();

    }

    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider != null)
            {
                IClicked click = hit.collider.gameObject.GetComponent<IClicked>();
                if (click != null) click.onClickAction();
                Debug.Log("3D Hit: " + hit.collider.tag);
            }
        }

        /*RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if(hits2D.collider != null)
        {
            Debug.Log("Hit2D Collideer" + hits2D.collider.tag);
        }*/
    }
}
