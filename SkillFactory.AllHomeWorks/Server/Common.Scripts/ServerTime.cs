namespace SkillFactory.AllHomeWorks.Server.Common.Scripts
{
    internal class ServerTime
    {


        private static DateTime serverTime = DateTime.Now;

        internal static DateTime GetServerTime() => serverTime;
    }
}
