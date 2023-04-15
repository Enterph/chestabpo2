using UnityEngine;

public class Player_look : MonoBehaviour
{
    float mouseSense = 1; // Чувствительность мыши

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked; // Скрываем курсор

        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;

        Vector3 rotPlayer = transform.rotation.eulerAngles;

        rotPlayer.x -= rotateY;
        rotPlayer.z = 0;
        rotPlayer.y += rotateX;

        transform.rotation = Quaternion.Euler(rotPlayer);
    }
}