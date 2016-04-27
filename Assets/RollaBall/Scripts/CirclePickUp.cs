using UnityEngine;
using System.Collections;

public class CirclePickUp : MonoBehaviour {

    public Object PickUp;
    private float distance = 8;
    private int count = 12;

    void Start () {
        DrawCircle(transform.position);
    }

    private void DrawCircle(Vector3 point) {
        point.y = 1;
        float angle = 360 * Mathf.Deg2Rad;
        for (int i = 1; i <= count; i++) {
            point.z = transform.position.z + Mathf.Cos(angle / count * i) * distance;
            point.x = transform.position.x + Mathf.Sin(angle / count * i) * distance;
            GameObject.Instantiate(PickUp, point, Quaternion.identity);
        }
    }
}
