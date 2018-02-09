﻿using System.ComponentModel;
using System.Xml.Serialization;
using System.Collections.Generic;

using Libraries.enums;
using Libraries.database.models.quest;


namespace Libraries.database.models
{
    
    /// <summary>
    /// Quest model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "quest")]
    public class ModelQuest
    {

        [XmlElement(ElementName = "displayname")]
        [DefaultValue(null)]
        public string Displayname { get; set; }

        [XmlElement(ElementName = "level")]
        public int Level { get; set; }
        
        [XmlElement(ElementName = "difficultycoloroverride")]
        public int Difficultycoloroverride { get; set; }

        [XmlElement(ElementName = "repeatable")]
        public string Repeatable { get; set; }

        [XmlElement(ElementName = "offertype")]
        public OfferTypes Offertype { get; set; }

        [XmlElement(ElementName = "timer")]
        public ModelQuestTimer Timer { get; set; }

        [XmlElement(ElementName = "canplaycoop")]
        public string Canplaycoop { get; set; }

        [XmlElement(ElementName = "cooprequired")]
        public string Cooprequired { get; set; }

        [XmlElement(ElementName = "ranked")]
        public string Ranked { get; set; }

        [XmlElement(ElementName = "alliance")]
        public AllianceTypesPrefix Alliance { get; set; }
        
        [XmlElement(ElementName = "description")]
        [DefaultValue(null)]
        public string Description { get; set; }

        [XmlElement(ElementName = "completiontext")]
        [DefaultValue(null)]
        public string Completiontext { get; set; }

        [XmlElement(ElementName = "inprogresstext")]
        [DefaultValue(null)]
        public string Inprogresstext { get; set; }

        [XmlElement(ElementName = "summarytext")]
        [DefaultValue(null)]
        public string Summarytext { get; set; }

        [XmlElement(ElementName = "repeatableduration")]
        public int Repeatableduration { get; set; }

        [XmlElement(ElementName = "canabandon")]
        public string Canabandon { get; set; }

        [XmlElement(ElementName = "hiddenquest")]
        public string Hiddenquest { get; set; }

        [XmlElement(ElementName = "friendonly")]
        public string Friendonly { get; set; }

        [XmlElement(ElementName = "suppressnotifications")]
        public string Suppressnotifications { get; set; }

        [XmlElement(ElementName = "customquest")]
        public string Customquest { get; set; }

        [XmlElement(ElementName = "questtype")]
        public QuestTypes Questtype { get; set; }

        [XmlElement(ElementName = "questgamemodetype")]
        public QuestgamemodeTypes Questgamemodetype { get; set; }

        [XmlElement(ElementName = "prereqs")]
        public ModelQuestPrereqs Prereqs { get; set; }

        [XmlElement(ElementName = "equipmentprereqs")]
        public string Equipmentprereqs { get; set; }

        [XmlElement(ElementName = "targets")]
        public ModelQuestTargets Targets { get; set; }
        
        [XmlElement(ElementName = "objectives")]
        public ModelQuestObjectives Objectives { get; set; }

        [XmlElement(ElementName = "secondaryobjectives")]
        public List<ModelQuestSecondaryobjectives> Secondaryobjectives { get; set; }

        [XmlElement(ElementName = "onaccept")]
        public ModelQuestOnaccept Onaccept { get; set; }

        [XmlElement(ElementName = "rewards")]
        public ModelQuestRewards Rewards { get; set; }

        [XmlElement(ElementName = "customloadscreen")]
        [DefaultValue(null)]
        public string Customloadscreen { get; set; }

        [XmlElement(ElementName = "secondaryrewards")]
        public List<ModelQuestSecondaryrewards> Secondaryrewards { get; set; }

        [XmlElement(ElementName = "timereffects")]
        public List<ModelQuestTimereffects> Timereffects { get; set; }

        [XmlElement(ElementName = "playersettings")]
        public List<ModelQuestPlayersettings> Playersettings { get; set; }

        [XmlElement(ElementName = "diplomacysettings")]
        public List<ModelQuestDiplomacysettings> Diplomacysettings { get; set; }

        [XmlElement(ElementName = "randommap")]
        public ModelQuestRandommap Randommap { get; set; }

        [XmlElement(ElementName = "questgivers")]
        public ModelQuestQuestgivers Questgivers { get; set; }
        
        [XmlElement(ElementName = "questreturners")]
        public ModelQuestQuestreturners Questreturners { get; set; }

        [XmlElement(ElementName = "objectiveimage")]
        [DefaultValue(null)]
        public string Objectiveimage { get; set; }

        [XmlElement(ElementName = "maplocationx")]
        [DefaultValue(null)]
        public string Maplocationx { get; set; }

        [XmlElement(ElementName = "maplocationy")]
        [DefaultValue(null)]
        public string Maplocationy { get; set; }

        [XmlElement(ElementName = "mapmarker")]
        [DefaultValue(null)]
        public string Mapmarker { get; set; }

        [XmlElement(ElementName = "mappage")]
        [DefaultValue(null)]
        public string Mappage { get; set; }

        [XmlElement(ElementName = "elitespawnchance")]
        public string Elitespawnchance { get; set; }

        [XmlElement(ElementName = "linkedquestid")]
        public int Linkedquestid { get; set; }

        [XmlElement(ElementName = "questbasescale")]
        public string Questbasescale { get; set; }

        [XmlElement(ElementName = "victoryconditions")]
        public string Victoryconditions { get; set; }
        
        [XmlAttribute(AttributeName = "uniqueid")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public int Version { get; set; }

        [XmlIgnore]
        public string Source { get; set; }

    }

}
