using Modding;
using System.Collections.Generic;
using UnityEngine;

namespace WorseSteadyBody {
    public class WorseSteadyBody: Mod {
        new public string GetName() => "WorseSteadyBody";
        public override string GetVersion() => "1.0.0.0";

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects) {
            On.HeroController.Bounce += bounce;
            On.HeroController.BounceHigh += bounceHigh;
            On.HeroController.ShroomBounce += shroomBounce;
            On.HeroController.RecoilRightLong += recoilRightLong;
            On.HeroController.RecoilLeftLong += recoilLeftLong;
            On.HeroController.RecoilDown += recoilDown;
        }

        private void bounce(On.HeroController.orig_Bounce orig, HeroController self) {
            if(!self.playerData.GetBool("equippedCharm_14")) {
                orig(self);
            }
        }

        private void bounceHigh(On.HeroController.orig_BounceHigh orig, HeroController self) {
            if(!self.playerData.GetBool("equippedCharm_14")) {
                orig(self);
            }
        }

        private void shroomBounce(On.HeroController.orig_ShroomBounce orig, HeroController self) {
            if(!self.playerData.GetBool("equippedCharm_14")) {
                orig(self);
            }
        }

        private void recoilRightLong(On.HeroController.orig_RecoilRightLong orig, HeroController self) {
            if(!self.playerData.GetBool("equippedCharm_14")) {
                orig(self);
            }
        }

        private void recoilLeftLong(On.HeroController.orig_RecoilLeftLong orig, HeroController self) {
            if(!self.playerData.GetBool("equippedCharm_14")) {
                orig(self);
            }
        }

        private void recoilDown(On.HeroController.orig_RecoilDown orig, HeroController self) {
            if(!self.playerData.GetBool("equippedCharm_14")) {
                orig(self);
            }
        }
    }
}