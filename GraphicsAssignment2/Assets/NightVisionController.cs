using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(PostProcessVolume))]
public class NightVisionController : MonoBehaviour
{
    [SerializeField] private Color defaultLightColour;
    [SerializeField] private Color boostedLightColour;

    private PostProcessVolume volume;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.ambientLight = defaultLightColour;
        volume = gameObject.GetComponent<PostProcessVolume>();
        volume.weight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.ambientLight = boostedLightColour;
        volume.weight = 1;
    }
}
