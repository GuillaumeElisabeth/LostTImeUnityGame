﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Quest.Interfaces;
using Assets.Scripts.Quest.ObjectivesTypes;

namespace Assets.Scripts.Quest
{
    public class ObjectiveController : IQuestObjective
    {
        private int _questID;
        private int _objectiveID;
        private string _objectiveName;
        private string _objectiveDescription;
        private TypeCollect _typeCollect;
        private TypeTalkToPNJ _typeTalkToPNJ;
        private bool _isComplete;

        public ObjectiveController(int objectiveID, string objectiveName, string objectiveDescription, TypeCollect typeCollect, bool isComplete)
        {
            ObjectiveID = objectiveID;
            ObjectiveName = objectiveName;
            ObjectiveDescription = objectiveDescription;
            TypeCollect = typeCollect;
            IsComplete = isComplete;
        }

        public ObjectiveController(int objectiveID, string objectiveName, string objectiveDescription, TypeTalkToPNJ typeTalkToPNJ, bool isComplete)
        {
            ObjectiveID = objectiveID;
            ObjectiveName = objectiveName;
            ObjectiveDescription = objectiveDescription;
            TypeTalkToPNJ = typeTalkToPNJ;
            IsComplete = isComplete;
        }

        /// <summary>
        /// Gets the quest identifier.
        /// </summary>
        /// <value>
        /// The quest identifier.
        /// </value>
        public int QuestID
        {
            get { return _questID; }
        }

        /// <summary>
        /// Gets or sets the objective identifier.
        /// </summary>
        /// <value>
        /// The objective identifier.
        /// </value>
        public int ObjectiveID
        {
            get { return _objectiveID; }
            set { _objectiveID = value; }
        }

        /// <summary>
        /// Gets or sets the name of the objective.
        /// </summary>
        /// <value>
        /// The name of the objective.
        /// </value>
        public string ObjectiveName
        {
            get { return _objectiveName; }
            set { _objectiveName = value; }
        }

        /// <summary>
        /// Gets or sets the objective description.
        /// </summary>
        /// <value>
        /// The objective description.
        /// </value>
        public string ObjectiveDescription
        {
            get { return _objectiveDescription; }
            set { _objectiveDescription = value; }
        }
        
        /// <summary>
        /// Gets or sets a value indicating whether this objective is complete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this objective is complete; otherwise, <c>false</c>.
        /// </value>
        public bool IsComplete
        {
            get { return _isComplete; }
            set { _isComplete = value; }
        }

        public TypeCollect TypeCollect
        {
            get
            {
                return _typeCollect;
            }

            set
            {
                _typeCollect = value;
            }
        }

        public TypeTalkToPNJ TypeTalkToPNJ
        {
            get
            {
                return _typeTalkToPNJ;
            }

            set
            {
                _typeTalkToPNJ = value;
            }
        }
    }
}