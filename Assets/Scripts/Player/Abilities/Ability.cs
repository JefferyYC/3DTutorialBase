﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("All main information about this ability")]
    protected AbilityInfo m_Info;
    #endregion

    #region Cached Components
    protected ParticleSystem cc_PS;
    #endregion

    #region Initialization
    private void Awake()
    {
        cc_PS = GetComponent<ParticleSystem>();
    }
    #endregion

    #region Use Methods
    public abstract void Use(Vector3 spawnPos);
    #endregion
}
