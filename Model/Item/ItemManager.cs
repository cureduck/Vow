using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Model
{
    class ItemManager:MonoBehaviour
    {
        public Item[] items;

        private void Start()
        {
            var resources = Resources.LoadAll<Sprite>("Texture/");
            BigPotion.Set(resources.First((s)=> { return s.name == "Red Potion";}));
        }
    }
}
