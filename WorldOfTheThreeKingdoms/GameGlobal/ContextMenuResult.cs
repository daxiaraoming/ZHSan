﻿using System;



namespace GameGlobal
{
    public enum ContextMenuResult
    {
        None,
        KeepShowing,
        Architecture_Detail,
        Architecture_Persons,
        Architecture_Militaries,
        Architecture_NoFactionPersons,
        Architecture_Facilities,
        Architecture_Captive,
        Architecture_Treasure,
        Architecture_Informations,
        Architecture_Princesses,
        Architecture_LandLink,
        Architecture_WaterLink,
        Faction_Detail,
        Faction_Architectures,
        Faction_Troops,
        Faction_Persons,
        Faction_Children,
        Faction_Militaries,
        Faction_TransferingMilitaries,
        Faction_AvailableMilitaryKinds,
        Faction_Captive,
        Faction_SelfCaptive,
        Faction_DiplomaticRelations,
        Faction_Techniques,
        Faction_Sections,
        Faction_Treasure,
        Faction_Informations,
        Internal_StopWork,
        Internal_zhenzai,
        Internal_Agriculture,
        Internal_Commerce,
        Internal_Technology,
        Internal_Domination,
        Internal_Morale,
        Internal_Endurance,
        Internal_Facility_Build,
        Internal_Facility_Demolish,
        Internal_Facility_StopBuilding,//停止建设
        Internal_Trade_BuyFood,
        Internal_Trade_SellFood,
        Internal_Expand,
        Military_Campaign,
        Military_CampaignAuto,
        Military_Transfer, //运兵
        Military_Troopership,
        Military_Training,
        Military_New,
        Military_Recruitment,
        Military_Merge,
        Military_Disband,
        Military_LevelUp,
        Routeway_Design,
        Routeway_PointShortestNormal,
        Routeway_PointShortestNoWater,
        Routeway_ArchitectureShortestNormal,
        Routeway_ArchitectureShortestNoWater,
        Routeway_CloseAll,
        Routeway_DemolishAll,
        //Transport_Resource,
        Transport_Fund,
        Transport_Food,
        Person_Transfer,
        Person_Convene,
        Person_Appointment_AppointMayor, //任命县令
        Person_Appointment_RecallMayor,  //罢免县令
        Person_Appointment_AppointOfficer,//任命官员
        Person_Appointment_RecallOfficer,//罢免官员
        Person_Hire,
        Person_Convince,
        Person_AutoHire,
        Person_Reward,
        Person_RewardAll,
        Person_Redeem,
        Person_Study_Skill,
        Person_Study_Title,
        Person_Study_Stunt,
        RoutewayEdit,
        RoutewayShowArea,
        RoutewayBuild,
        RoutewayClose,
        RoutewayDemolish,
        Tactics_Information,
        Tactics_StopInformation,
        //Tactics_Spy,
        Tactics_Destroy,
        Tactics_Instigate,
        Tactics_Gossip,
        Tactics_Search,
        Tactics_JailBreak,
        Tactics_Assassinate,
        Diplomacy,
        Faction_Diplomatic_EnhanceDiplomaticRelation,
        Faction_Diplomatic_AllyDiplomaticRelation,
        Faction_Diplomatic_ResetDiplomaticRelation,
        Faction_Diplomatic_DenounceDiplomaticRelation,
        Faction_Diplomatic_TruceDiplomaticRelation,
        Faction_Diplomatic_QuanXiangDiplomaticRelation,//劝降
        Faction_Diplomatic_GeDiDiplomaticRelation,//割地
        Faction_officePosition_jingongzijin,
        Faction_officePosition_jingongliangcao,
        Faction_officePosition_SelfBecomeEmperor,
        Faction_officePosition_BecomeEmperorLegally,
        Faction_changeCapital,
        Faction_selectPrince,
      //  Faction_ZhaoXianBang_AutoCreatePerson, //招贤榜
       // Faction_ZhaoXianBang_AutoZhaoXian,
        Faction_ZhaoXianBang_GenerateOfficer,
      //  Faction_ZhaoXianBang_DengYong,  //登用
        Faction_ZhaoXianBang_DismissOfficer, //遣散
        Faction_ManageTechniques,
        Monarch_MakeMarriage,
        Monarch_MakeMarriage2,//纳妾
        Monarch_TrainChildren,
        Faction_KillRelease_ReleaseSelfPerson,
        Faction_KillRelease_MoveCaptive, //转移俘虏
        Faction_KillRelease_ReleaseCaptive,
        Faction_KillRelease_KillPerson,
        Faction_KillRelease_KillCaptive,
        Faction_PromoteNvGuan,
        Monarch_hougongTop_nafei,
        Monarch_hougongTop_hougong,
        Monarch_hougongTop_moveFeizi,
        Monarch_hougongTop_releaseFeizi,
        Faction_Refuse,
        Faction_Treasure_Confiscate,
        Faction_Treasure_Award,
        Faction_Treasure_Sell,
        Section_New,
        Section_Regroup,
        Section_Disband,
        Person_Hiring,
        Person_AutoReward,
        Internal_AutoWorking,
        Military_AutoRecruiting,
        Tactics_AutoSearching,
        AllEnter,
        DateGo_1Day,
        DateGo_2Days,
        DateGo_5Days,
        DateGo_10Days,
        DateGo_30Days,
        Jump_Architecture,
        Jump_Troop,
        Jump_Person,
        Switch_Smog,
        Switch_TroopTitle,
        Switch_Music,
        Switch_NormalSound,
        Switch_BattleSound,
        Switch_TroopVoice,
        Switch_TroopAnimation,
        Switch_FullScreen,
        Switch_SkyEye,
        Switch_MultipleResource,
        Switch_StopOnAttack,
        Information_AllSkills,
        Information_AllTitles,
        Information_AllMilitaryKinds,
        Information_AllStunts,
        Information_AllFactions,
        Information_AllArchitectures,
        Information_AllTroops,
        Information_AllPersons,
        Information_AllMilitaries,
        Information_AllFacilities,
        Information_AllTerrainDetails,
        Information_AllSections,
        Information_AllRegions,
        Information_AllStates,
        Information_AllTreasures,
        Information_AllGuanjues,
        Information_AllDeadPersons,
        Load,
        Save,
        System,
        TroopMove,
        TroopTarget,
        TroopCombatMethod_Cancel,
        TroopCombatMethod,
        TroopAutoCombatMethod,
        TroopConfig_TroopChallengeCommand,
        //TroopChallengeCommand_Cancel,
        TroopStunt,
        TroopStratagem_Cancel,
        TroopStratagem_0,
        TroopStratagem_1,
        TroopStratagem_2,
        TroopStratagem_3,
        TroopStratagem_4,
        TroopStratagem_5,
        TroopStratagem_6,
        TroopStratagem_7,
        TroopStratagem_8,
        TroopStratagem_9,
        TroopStratagem_10,
        TroopStratagem_11,
        TroopStratagem_12,
        TroopStratagem_13,
        TroopStratagem_14,
        TroopStratagem_15,
        TroopStratagem_16,
        TroopStratagem_17,
        TroopStratagem_18,
        TroopStratagem_19,
        TroopEnter,
        TroopOccupy,
        TroopAction_LevyFood,
        TroopCutRouteway,
        TroopConfig_AttackDefaultKind,
        TroopConfig_AttackTargetKind,
        TroopConfig_CastDefaultKind,
        TroopConfig_CastTargetKind,
        TroopSetAuto,
        TroopIdle,
        TroopDetail,
        TroopPersons,
        TroopMilitary,
        TroopCaptive,
        TroopTreasure,
        TroopMorph,
        TroopInfo,
        TroopInfo_TroopDetail,
        TroopInfo_TroopPersons,
        TroopInfo_TroopMilitary,
        TroopInfo_TroopCaptive,
        TroopInfo_TroopTreasure,
        Plugins,
        CurrentArchitectureLeftClick,
        CurrentTroopLeftClick,
        CurrentArchitectureRightClick,
        CurrentTroopRightClick,
        CurrentRoutewayRightClick,
        YearTable_Year5,
        YearTable_OwnFaction,
        ChangeFaction,
        Switch_SkyEyeSimpleNotification
    }
}

