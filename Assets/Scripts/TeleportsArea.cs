using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportsArea : MonoBehaviour
{
    #region Inspector
    [SerializeField] private List<GameObject> teleportMeshes = new();
    #endregion

    public List<GameObject> ObjectsForTeleport
    {
        get => teleportMeshes;
        set => teleportMeshes = value;
    }
}