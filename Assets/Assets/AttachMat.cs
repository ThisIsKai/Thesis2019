using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AttachMat : MonoBehaviour {

    public Material matToApply;

    public void OnRenderImage (Texture inputTex, RenderTexture outputTex){
        Graphics.Blit(inputTex, outputTex, matToApply);
    }
}
