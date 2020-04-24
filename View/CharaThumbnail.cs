using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model;
using UnityEngine.UI;
using TMPro;

namespace View
{
    public class CharaThumbnail : MonoBehaviour
    {
        public Animal owner;

        [SerializeField]
        private Slider HpSlider;
        [SerializeField]
        private Slider SpSlider;
        [SerializeField]
        private TMP_Text hpText;
        [SerializeField]
        private TMP_Text spText;

        private void UpdateUI()
        {
            HpSlider.value = (float)owner.curHp / (float)owner.maxHp;
            SpSlider.value = (float)owner.curSp / (float)owner.maxSp;
            hpText.text = owner.curHp + "/" + owner.maxHp;
            spText.text = owner.curSp + "/" + owner.maxSp;
        }

        void Start()
        {
            UpdateUI();
            owner.AttrUpdated += UpdateUI;
        }

        void Update()
        {

        }
    }
}

