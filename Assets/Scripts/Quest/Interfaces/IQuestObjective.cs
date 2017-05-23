﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Quest.ObjectiveTypes;

namespace Assets.Scripts.Quest.Interfaces
{
    public interface IQuestObjective
    {
        /// <summary>
        /// Gets the quest identifier.
        /// </summary>
        /// <value>
        /// The quest identifier.
        /// </value>
        int QuestID { get; }

        /// <summary>
        /// Gets or sets the objective description.
        /// </summary>
        /// <value>
        /// The objective description.
        /// </value>
        string ObjectiveDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is complete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is complete; otherwise, <c>false</c>.
        /// </value>
        bool IsComplete { get; set; }

        /// <summary>
        /// Gets or sets the type of the objective.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        EnumTypes Type { get; set; }
    }
}
