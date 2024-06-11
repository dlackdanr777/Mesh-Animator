using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMeshController : MonoBehaviour
{
    [SerializeField] private AnimatedMesh[] _meshes;

    public void Start()
    {
        Play("Z_Idle");
    }

    public void Play(string animationName)
    {
        for(int i = 0, count =  _meshes.Length; i < count; i++)
        {
            _meshes[i].Play(animationName);
        }
    }
}
