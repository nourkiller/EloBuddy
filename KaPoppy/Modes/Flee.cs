﻿using EloBuddy;
using EloBuddy.SDK;
using KaPoppy;
namespace Modes
{
    using System.Linq;
    using Menu = Settings.FleeSettings;
    class Flee : Helper
    {

        public static void Execute()
        {
            var target = ObjectManager.Get<Obj_AI_Minion>().Where(x => x.Distance(Game.CursorPos) < myHero.Distance(Game.CursorPos)).OrderBy(x => x.Distance(myHero));
            if (target == null) return;

            if (Menu.UseE)
            {
                if (target.Count() > 0)
                {
                    if (Lib.E.IsReady() && Lib.E.IsInRange(target.First()))
                    {
                        Lib.E.Cast(target.First());
                    }
                }
            }
            if (Menu.UseW)
            {
                if (myHero.CountEnemiesInRange(1000) > 0)
                {
                    Lib.W.Cast();
                }
            }
        }
    }
}
