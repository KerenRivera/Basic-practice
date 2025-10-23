using System;

namespace Annalyn_s_Infiltration
{
    static class AnnalynsInfiltration
    {
        public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) =>

            knightIsAwake || archerIsAwake || prisonerIsAwake;

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) =>

            !archerIsAwake && prisonerIsAwake;

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) =>

         (petDogIsPresent && !archerIsAwake) || (!knightIsAwake && !archerIsAwake && prisonerIsAwake);

    }
}
