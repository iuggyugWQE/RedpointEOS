// Copyright June Rhodes. All Rights Reserved.

using UnrealBuildTool;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

public class RedpointEOSAuthDiscord : ModuleRules
{
    public RedpointEOSAuthDiscord(ReadOnlyTargetRules Target) : base(Target)
    {
        DefaultBuildSettings = BuildSettingsVersion.V2;
        bUsePrecompiled = true;

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "OnlineSubsystemRedpointEOS",
                "RedpointEOSSDK",
            }
        );

        if (OnlineSubsystemRedpointEOSConfig.GetBool(Target, "ENABLE_DISCORD", false))
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "Discord",
                }
            );
        }

    }
}
