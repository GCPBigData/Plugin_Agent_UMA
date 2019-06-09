﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using wizardscode.editor;
using wizardscode.validation;

namespace wizardscode.plugin
{
    [CreateAssetMenu(fileName = "UMA_Agent_Profile", menuName = "Wizards Code/Agent/UMA Profile")]
    class UMA_Agent_Profile : AbstractPluginProfile
    {
        [Tooltip("The UMA DCS prefab that provides all the necessary code to create UMA characters.")]
        [Expandable(isRequired: true)]
        public PrefabSettingSO UMAPrefab;
        
        [Tooltip("The definition of an UMA character.")]
        [Expandable(isRequired: true)]
        public UMASettingSO agent;
    }
}
