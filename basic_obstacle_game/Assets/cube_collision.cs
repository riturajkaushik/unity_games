using UnityEngine;

public class cube_collision : MonoBehaviour
{
    void OnCollisionEnter(Collision info)
    {
        // Debug.Log(info.collider.name);
        // if(info.collider.name=="obstacle")
        if(info.collider.tag=="Obstacle")
            Debug.Log("Obstacle hit");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
