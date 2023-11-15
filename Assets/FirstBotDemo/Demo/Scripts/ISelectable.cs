using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstBotDemo
{
    public interface ISelectable
    {
        public void Select();

        public void Deselect();
    }
}