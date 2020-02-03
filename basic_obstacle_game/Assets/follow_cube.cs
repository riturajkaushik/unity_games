using UnityEngine;

public class follow_cube : MonoBehaviour
{
    public Transform cube;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(cube.position);
        transform.position = cube.position + offset;
    }
}
