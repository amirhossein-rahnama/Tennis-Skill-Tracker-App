using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace MyNamespace
{
    public static class GetPlayerSkillFunction
    {
        [FunctionName("GetPlayerSkill")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "players/{playerName}/skill")] HttpRequest req,
            string playerName,
            ILogger log)
        {
            // Implementation of database query to retrieve skill level of player
            int playerSkillLevel = await GetPlayerSkill(playerName);

            if (playerSkillLevel == -1)
            {
                return new NotFoundObjectResult($"Player with name {playerName} not found.");
            }
            else
            {
                return new OkObjectResult($"Skill level of {playerName} is {playerSkillLevel}");
            }
        }

        // Implementation of database query to retrieve skill level of player
        private static async Task<int> GetPlayerSkill(string playerName)
        {
            // TODO: Implement database query to retrieve skill level of player
            // For example: 
            // var db = new MyDatabaseContext();
            // var player = await db.Players.FirstOrDefaultAsync(p => p.Name == playerName);
            // return player?.SkillLevel ?? -1;
            return 6;
        }
    }
}
