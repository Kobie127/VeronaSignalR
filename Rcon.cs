namespace VeronaSingalr
{
    public class Rcon
    {
        private RconType FormRconCommand(
            string gameId, 
            string command, 
            string? itemId = null, 
            string? playerId = null
        )
        {
            RconType rconCommand = new RconType() { result = "" };
            try
            {
                if (gameId == "minecraft")
                {
                    switch (command)
                    {
                        case "kill":
                            rconCommand.result = $"kill {playerId}";
                            break;
                        case "kick":
                            rconCommand.result = $"kick {playerId}";
                            break;
   
                        // should not get here as all commands are accounted for
                        default:
                            break;
                    }
                }

                if (gameId == "tf2")
                {
                    // Nothing here yet
                }
            }
            // Should probably come up with unique exception
            catch (Exception e)
            { 
                rconCommand.result = e.Message;
 
            }
            return rconCommand;
        }

        public RconType GetRconcCommand(
            string gameId, 
            string command, 
            string? itemId = null, 
            string? playerId = null
        )
        {
            return FormRconCommand(gameId, command, itemId, playerId);
        }
    }
}
