<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/jeffsnff/tic_tac_toe">
    <img src="./Assets/tic_tac_toe_logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Tic Tac Toe</h3>

  <p align="center">
    A two player game of Tic Tac Toe
    <br />
    <br />
    <a href="https://github.com/jeffsnff/tic_tac_toe/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    ·
    <a href="https://github.com/jeffsnff/tic_tac_toe/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>


<!-- ABOUT THE PROJECT -->
## About The Project

Tic Tac Toe is a console application game built using C#. This was a boss fight from the [The C# Player's Guide](https://csharpplayersguide.com/) book that I am using to learn C#.

### Built With

[![C#](https://custom-icon-badges.demolab.com/badge/C%23-%23239120.svg?logo=cshrp&logoColor=white)](#)

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites
1. Install Visual Studio Code
2. Install C# Dev Kit

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/jeffsnff/tic_tac_toe.git
   ```
2. Change git remote url to avoid accidental pushes to base project
   ```sh
   git remote set-url origin github_username/repo_name
   git remote -v # confirm the changes
   ```
3. Run Program

<!-- USAGE EXAMPLES -->
## Usage
Play a game with a friend or a signifigant other!

<!-- ROADMAP -->
## Roadmap
When I presented this project to some other developers, one had a few suggestions which I documented in the issues section of the repository. Around August, I plan on working on these changes after learning some more.
### Update on Roadmap
Spent two days refactoring this project. 
I used issues and branching to track it in the issue tracker which was cool.

I updated the types from byte and char to int and enum Symbol. The Symbol is used for when the game starts and assigns player one an X and player two an O.

For the Player class I updated it to use Symbol enum instead. Made the field private and created a GetSymbol method, which I just realized as writing this could actually just be a getter. I configured it that way, but made the method wrong.

For the Board class, I moved the turn variable into a field and added a getter and setter. Created a NextTurn method to update that by one, BUT implimented a getter method? correctly to just get the turn value from the Board object. I moved all the LegalMove logic into a method inside the Board class as well as CheckWin.

I then moved the game logic into a method inside Program.cs which then gave me the confidence to move it into Player.cs.

Refactoring this project, which I am sure there is more I can do, has given me better understanding of OOP, specifically encapsulation. I THINK, I could even create Interfaces for DrawBoard, CheckWin, LegalMove and UpdateBoard to practice Interfaces.

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments
Thanks to [Othneil Drew](https://github.com/othneildrew/Best-README-Template/blob/main/README.md) for putting this README.md template together.
