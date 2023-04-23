using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Model
{
    public interface IFallingItem: ISceneObject
    {
        public bool IsActive { get; set; }
        public event Action<bool> ObjectActiveted;
    }
}

