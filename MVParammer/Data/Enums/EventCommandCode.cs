namespace MVParammer.Data.Enums
{
    /// <summary>
    /// Command names mostly come from comments in the source code, above functions like Game_Interpreter.prototype.command101 in rpg_objects.js.
    /// </summary>
    /// <remarks>Incomplete</remarks>
    public enum EventCommandCode : int
    {
        ShowText = 101,
        ShowChoices = 102,
        InputNumber = 103,
        SelectItem = 104,
        ShowScrollingText = 105,
        Comment = 108,
        ConditionalBranch = 111,
        Loop = 112,
        BreakLoop = 113,
        ExitEventProcessing = 115,
        CommonEvent = 117,
        Label = 118,
        JumpToLabel = 119,
        ControlSwitches = 121,
        ControlVariables = 122,
        ControlSelfSwitch = 123,
        ControlTimer = 124,
        ChangeGold = 125,
        ChangeItems = 126,
        ChangeWeapons = 127,
        ChangeArmors = 128,
        ChangePartyMember = 129,
        ChangeBattleBGM = 132,
        ChangeVictoryME = 133,
        ChangeSaveAccess = 134,
        ChangeMenuAccess = 135,
        ChangeEncounterDisable = 136,
        ChangeFormationAccess = 137,
        ChangeWindowColor = 138,
        ChangeDefeatME = 139,
        ChangeVehicleBGM = 140,
        TextData = 401,
        WhenChoice = 402,
        WhenCancel = 403,
        Else = 411,
        RepeatAbove = 413
    }
}
