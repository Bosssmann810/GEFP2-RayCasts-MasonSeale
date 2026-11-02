using UnityEngine;
using TMPro;
public class RaycastScript : MonoBehaviour
{
    public Camera cam;
    public TextMeshProUGUI text;
    public LayerMask layerMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 100, layerMask))
        {
            text.text = hit.collider.gameObject.name;
            hit.transform.GetComponent<Renderer>().material.color = Color.blue; 
        }
    }
}
