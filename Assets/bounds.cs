using JetBrains.Annotations;
using UnityEngine;

public class bounds : MonoBehaviour
{
    public void CalculatePixelSize() {

    GameObject box = GameObject.Find("Furnace");

    float boxWidth = box.transform.localScale.x;

    float boxHeight = box.transform.localScale.y;

    float boxLength = box.transform.localScale.z;



    // Access camera properties

    Camera camera = Camera.main;

    float fov = camera.fieldOfView;

    float nearClip = camera.nearClipPlane;

    float farClip = camera.farClipPlane;



    // Calculate pixel-to-world unit conversion

    float pixelPerWorldUnit = Screen.width / (2 * Mathf.Tan(fov * Mathf.Deg2Rad / 2) * nearClip);



    // Calculate pixel size of box based on camera perspective

    float pixelWidth = boxWidth * pixelPerWorldUnit;

    float pixelHeight = boxHeight * pixelPerWorldUnit;

    float pixelLength = boxLength * pixelPerWorldUnit;

    Debug.Log("Pixel width: " + pixelWidth + ", Pixel height: " + pixelHeight + ", Pixel length:" + pixelLength);

}
void Start()

{
    CalculatePixelSize();
}
}
