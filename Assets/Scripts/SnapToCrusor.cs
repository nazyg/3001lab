using UnityEngine;

public class SnapToCrusor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = mouse;            
        
    }
}
