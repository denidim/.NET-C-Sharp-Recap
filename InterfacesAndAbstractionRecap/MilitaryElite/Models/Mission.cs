namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;

    internal class Mission : IMission
    {
        private MissionStateEnum missionState;

        private string codeName;

        public Mission(string codeName, MissionStateEnum missionState)
        {
            this.CodeName = codeName;
            this.MissionState = missionState;
        }

        public MissionStateEnum MissionState { get => missionState; private set => missionState = value; }

        public string CodeName { get => codeName; private set => codeName = value; }

        public void CompleteMission()
        {
            this.missionState = MissionStateEnum.Finished;
        }
    }
}
