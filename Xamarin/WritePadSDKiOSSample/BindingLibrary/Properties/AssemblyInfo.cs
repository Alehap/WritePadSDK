﻿using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith("libWritePadRecoUniversal.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks = "Foundation", ForceLoad = true, IsCxx = true)]