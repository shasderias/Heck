﻿namespace Heck.HarmonyPatches
{
    using System;
    using HarmonyLib;

    [HarmonyPatch(
        typeof(MultiplayerLevelScenesTransitionSetupDataSO),
        new Type[] { typeof(string), typeof(IPreviewBeatmapLevel), typeof(BeatmapDifficulty), typeof(BeatmapCharacteristicSO), typeof(IDifficultyBeatmap), typeof(ColorScheme), typeof(GameplayModifiers), typeof(PlayerSpecificSettings), typeof(PracticeSettings), typeof(bool) })]
    [HarmonyPatch("Init")]
    internal static class MultiplayerLevelScenesTransitionSetupDataSOInit
    {
        private static void Postfix(PlayerSpecificSettings playerSpecificSettings)
        {
            SceneTransitionHelper.Patch(playerSpecificSettings);
        }
    }
}
