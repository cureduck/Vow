using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Model
{
    [Serializable, CreateAssetMenu(fileName = "Nouse", menuName = "Model/TestItem", order = 0)]
    public abstract class ItemBase
    {
        public virtual string ItemName { get; }
        public string description;

        private static Sprite _sprite;
        public Sprite sprite { get => _sprite;}

        public static void Set(Sprite s)
        {
            _sprite = s;
        }
    }


    [Serializable,CreateAssetMenu(fileName = "Nouse", menuName = "Model/BaseItem", order = 0)]
    public class Item:ScriptableObject
    {
        [Header("ItemID")]
        public int ItemID;
        [Header("Image")]
        public Sprite sprite;

        [Header("Methods")]
        public bool Usable = false;
        public bool Equipable = false;

        [Header("Basic Info")]
        public string ItemName;
        [TextArea]
        public string Description;

        

    }

    public class Consum : Item
    {
        public int Capcility;

        
    }


    public abstract class Equipment : ItemBase
    {

    }

    public abstract class Weapon : Equipment
    {

    }

    [CreateAssetMenu(fileName = "Armor", menuName = "Model/Armor", order = 0)]
    public class Armor : Equipment
    {
        public float def;

    }

    public abstract class Consumpution : ItemBase
    {
        public abstract int capacity { get; }
        public int count { get; private set; }


        public virtual void Use(Animal user)
        {
            
            count -= 1;
            if (count==0)
            {
                
            }
            
        }

        public Consumpution(int count=10)
        {
            
            this.count = count;
            
        }

        
    }




}
