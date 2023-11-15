using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstBotDemo
{
    [CreateAssetMenu(menuName = "Entities/Enemy")]
    public class EnemyEntity : ScriptableObject
    {
        public string enemyName;
        public Sprite icon;
        public int hp;
    }
}