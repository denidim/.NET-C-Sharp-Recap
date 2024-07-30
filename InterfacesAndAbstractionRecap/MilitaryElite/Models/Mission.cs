namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;

    internal class Mission : IMission
    {
        private MissionStateEnum missionState;

        private string codeName;

        public Mission(MissionStateEnum missionState, string codeName)
        {
            this.MissionState = missionState;
            this.CodeName = codeName;
        }

        public MissionStateEnum MissionState { get => missionState; private set => missionState = value; }

        public string CodeName { get => codeName; private set => codeName = value; }

        public void CompleteMission()
        {
            this.missionState = MissionStateEnum.Finished;
        }
    }
}
