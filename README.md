# Tennis-Skill-Tracker-App

This project is a MAUI app that computes tennis players’ skills from the outcomes of the matches they play. The skill of each player is a number stored in a database and updated after each match.

Task Description
For the purpose of this task, we assume the user is already logged in, and the frontend is reduced to two capabilities – displaying the player’s skill and allowing the player to enter a match outcome. The latter is done in the following way:

First, the user selects if the match was singles or doubles. If singles, then they're asked to select an opponent (for simplicity, from a list of friends). If doubles, then they select their partner and the two players of the opposing team.
Finally, the user indicates who won. On the backend, this sends a request to an Azure function which:
pulls the current relevant skills from the database
together with the indicated winner, it sends these skills to a skill rating Azure function which computes the new skills
updates the players’ skills in the database. The frontend shows the updated player skill.
Here, we only implement the outer function. The inner, skill rating one, can be considered a blackbox and not within the scope of this task.

Example Scenario
Here’s an example: I log into the app, and I see that my current skill is 6. I had just played with my friend Alice and won. I enter this match results, and I see my updated skill go up to 8. Then, Bob and Charlie join us on court, and we play a match - Alice and I vs the two of them. We lose. I record this match result and see my updated skill go down to 7. Note, the games are played in the real world; only the match outcomes get entered in the app.

Expected Outcome
The expected outcome of this task is a MAUI app, a backend handling, and a database work. No need to cover the skill calculation or login.

Usage
The app can be downloaded from the repository and run on the appropriate development environment. Instructions on how to set up the app and the backend will be provided in the documentation.

Contributors
This project was developed by Amirhossein Rahnama as a part of a technical task. If you have any questions, please contact Amirhossein Rahnama via email at amirhosseinrahnama99@gmail.com.

Thank you for your interest in this project.
