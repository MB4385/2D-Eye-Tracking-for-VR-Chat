using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureEyeTracking : MonoBehaviour
{
    [Header("Materials Tracking")]
    public Material LeftEyeMaterial;
    public Material RightEyeMaterial;
    public GameObject LEyeJoint;
    public GameObject REyeJoint;

    [Range(1.0F, 69.0F)]
    public float sensitivity = 10.0f;
    [Range(-0.5F, 0.5F)]
    public float YOffset = 0.0F;
    [Range(-0.5F, 0.5F)]
    public float XOffset = 0.0F;
    public bool InvertAxis = false;
    void Update()
    {

        float ranglex = REyeJoint.transform.localEulerAngles.x;
        ranglex = (ranglex > 180) ? ranglex - 360 : ranglex;

        float rangley = REyeJoint.transform.localEulerAngles.y;
        rangley = (rangley > 180) ? rangley - 360 : rangley;

        if (InvertAxis)
        {
            RightEyeMaterial.mainTextureOffset = new Vector2(
              rangley / sensitivity + YOffset,
              ranglex / sensitivity + XOffset);
        }
        else 
        {
            RightEyeMaterial.mainTextureOffset = new Vector2(
            ranglex / sensitivity + XOffset,
            rangley / sensitivity + YOffset);
        }
    

        float langlex = LEyeJoint.transform.localEulerAngles.x;
        langlex = (langlex > 180) ? langlex - 360 : langlex;

        float langley = LEyeJoint.transform.localEulerAngles.y;
        langley = (langley > 180) ? langley - 360 : langley;

        if (InvertAxis)
        {
            LeftEyeMaterial.mainTextureOffset = new Vector2(
          langley / sensitivity + YOffset,
          langlex / sensitivity + XOffset);
        }
        else
        {
            LeftEyeMaterial.mainTextureOffset = new Vector2(
         langlex / sensitivity + XOffset,
         langley / sensitivity + YOffset);
        }
    }

}