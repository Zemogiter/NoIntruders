using Planetbase;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityModManagerNet;

//getHeight, getIcon, getSelectionBounds and getAnimationNames are placeholders to allow the code to compile, do not touch them unless needed
namespace NoIntruders
{
    public class NoIntruders : Character
    {
        public override float getHeight()
        {
            throw new NotImplementedException();
        }

        public override Texture2D getIcon()
        {
            throw new NotImplementedException();
        }

        public override Bounds getSelectionBounds()
        {
            throw new NotImplementedException();
        }
        [LoaderOptimization(LoaderOptimization.NotSpecified)]
        public static void Init(UnityModManager.ModEntry modData)
        {
            modData.OnUpdate = Update;
        }

        public static void Update(UnityModManager.ModEntry modData, float timeStep)
        {
            NoIntruders kill = new NoIntruders();            
            List<Character> intruders = getSpecializationCharacters(SpecializationList.IntruderInstance);
            if (intruders != null)
            {
                foreach (Character intruder in intruders)
                {
                    // kill intruders instantly.
                    if (intruder != null && !intruder.isDead())
                    {
                        intruder.setArmed(false);
                        kill.setDead();

                    }
                }
            }
        }

        protected override List<string> getAnimationNames(CharacterAnimationType animationType)
        {
            throw new NotImplementedException();
        }
    }
}
