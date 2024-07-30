namespace MilitaryElite.Interfaces
{
    using MilitaryElite.Enums;

    internal interface IMission
    {
        public string CodeName { get; }

        public MissionStateEnum MissionState { get; }

        void CompleteMission();
    }
}
