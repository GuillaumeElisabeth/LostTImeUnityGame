﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Quest.Interfaces;
using Assets.Scripts.Quest.ObjectivesTypes;

namespace Assets.Scripts.Quest
{
    public class QuestLog : IQuestObjective, IQuest
    {
        //IQuestObjective
        private int _questID;
        private int _objectiveID;
        private string _objectiveName;
        private string _objectiveDescription;
        private bool _isComplete;
        private ObjectiveTypes _types;

        //IQuest
        private string _questName;
        private string _questDescription;
        private string _questDialogue;
        private IList<IQuestObjective> _objectivesControllers;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestLog"/> class.
        /// </summary>
        /// <param name="questID">The quest identifier.</param>
        /// <param name="objectiveDescription">The objective description.</param>
        /// <param name="isComplete">if set to <c>true</c> [is complete].</param>
        public QuestLog(int questID, string objectiveDescription, bool isComplete, ObjectiveTypes objectiveType)
        {
            QuestID = questID;
            ObjectiveDescription = objectiveDescription;
            IsComplete = isComplete;
            Type = objectiveType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestLog"/> class.
        /// </summary>
        /// <param name="questName">Name of the quest.</param>
        /// <param name="questDescription">The quest description.</param>
        /// <param name="questDialogue">The quest dialogue.</param>
        public QuestLog(string questName, string questDescription, string questDialogue)
        {
            QuestName = questName;
            QuestDescription = questDescription;
            QuestDialogue = questDialogue;
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
            set { _questID = value; }
        }

        //
        public int ObjectiveID
        {
            get { return _objectiveID; }
            set { _objectiveID = value; }
        }

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
        /// Gets or sets a value indicating whether this instance is complete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is complete; otherwise, <c>false</c>.
        /// </value>
        public bool IsComplete
        {
            get { return _isComplete; }
            set { _isComplete = value; }
        }

        /// <summary>
        /// Checks the progress.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CheckProgress()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the name of the quest.
        /// </summary>
        /// <value>
        /// The name of the quest.
        /// </value>
        public string QuestName
        {
            get { return _questName; }
            set { _questName = value; }
        }

        /// <summary>
        /// Gets the quest description.
        /// </summary>
        /// <value>
        /// The quest description.
        /// </value>
        public string QuestDescription
        {
            get { return _questDescription; }
            set { _questDescription = value; }
        }

        /// <summary>
        /// Gets the quest dialogue.
        /// </summary>
        /// <value>
        /// The quest dialogue.
        /// </value>
        public string QuestDialogue
        {
            get { return _questDialogue; }
            set { _questDialogue = value; }
        }

        /// <summary>
        /// Gets or sets the type of the objective.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public ObjectiveTypes Type
        {
            get { return _types; }
            set { _types = value; }
        }

        public IList<IQuestObjective> Objectives
        {
            get { return _objectivesControllers; }
        }


    }
}
