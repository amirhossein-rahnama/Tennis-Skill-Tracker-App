using System;
using System.Threading.Tasks;

namespace TennisSkillApi
{
    public class PlayerManager
    {
        private readonly IDatabaseProvider _databaseProvider;
        private readonly ISkillRatingProvider _skillRatingProvider;

        public PlayerManager(IDatabaseProvider databaseProvider, ISkillRatingProvider skillRatingProvider)
        {
            _databaseProvider = databaseProvider;
            _skillRatingProvider = skillRatingProvider;
        }

        public async Task<int> GetPlayerSkill(string playerName)
        {
            // Retrieve the player's skill level from the database
            int skillLevel = await _databaseProvider.GetPlayerSkill(playerName);

            // Return the skill level, or 0 if the player is not found
            return skillLevel > 0 ? skillLevel : 0;
        }

        public async Task<bool> UpdatePlayerSkills(string[] playerNames, int winnerIndex)
        {
            // Determine the skill rating changes based on the match outcome
            int[] skillRatingChanges = _skillRatingProvider.GetSkillRatingChanges(playerNames, winnerIndex);

            // Update the players' skill levels in the database
            bool success = await _databaseProvider.UpdatePlayerSkills(playerNames, skillRatingChanges);

            return success;
        }
    }
}
