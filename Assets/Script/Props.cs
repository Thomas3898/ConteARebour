using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Props : MonoBehaviour
{
    Color m_HoverColor = Color.red;
    Color m_OriginalColor;
    MeshRenderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        m_Renderer.material.color = m_HoverColor;
    }

    private void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }
}
