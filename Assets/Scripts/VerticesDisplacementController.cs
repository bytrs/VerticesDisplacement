using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticesDisplacementController : MonoBehaviour
{
    [SerializeField] float m_distanceLimit = 1;
    [SerializeField] float m_magnitude = 1;
    [SerializeField] List<Renderer> m_renderers;

    void Update()
    {
        foreach (var renderer in m_renderers)
        {
            var m_material = renderer.material;
            m_material?.SetVector("_Point", transform.position);
            m_material?.SetFloat("_DistanceLimit", m_distanceLimit);
            m_material?.SetFloat("_Magnitude", m_magnitude);
        }
        transform.localScale = Vector3.one * m_distanceLimit;
    }


}
