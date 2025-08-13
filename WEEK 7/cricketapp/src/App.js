import React from "react";
import ListOfPlayers from "./components/ListOfPlayers";
import ScoreBelow70 from "./components/ScoreBelow70";
import OddPlayers from "./components/OddPlayers";
import EvenPlayers from "./components/EvenPlayers";
import IndianPlayers from "./components/IndianPlayers";

function App() {
  const flag = true;

  const players = [
    { name: "Jack", score: 50 },
    { name: "Michael", score: 70 },
    { name: "John", score: 40 },
    { name: "Arm", score: 61 },
    { name: "Elisabeth", score: 6 },
    { name: "Sachin", score: 95 },
    { name: "Dhoni", score: 100 },
    { name: "Virat", score: 84 },
    { name: "Jadeja", score: 64 },
    { name: "Raina", score: 75 },
    { name: "Rohit", score: 80 },
  ];

  const oddTeam = ["Sachin", "Virat", "Yuvaraj"];
  const evenTeam = ["Dhoni", "Rohit", "Raina"];

  const T20Players = ["First Player", "Second Player", "Third Player"];
  const RanjiPlayers = ["Fourth Player", "Fifth Player", "Sixth Player"];
  const IndianTeam = [...T20Players, ...RanjiPlayers];

  return (
    <div className="App">
      {flag === true ? (
        <>
          <h1>List of Players</h1>
          <ListOfPlayers players={players} />

          <hr />
          <h1>List of Players having Scores Less than 70</h1>
          <ScoreBelow70 players={players} />
        </>
      ) : (
        <>
          <h1>Indian Team</h1>
          <h2>Odd Players</h2>
          <OddPlayers players={oddTeam} />

          <h2>Even Players</h2>
          <EvenPlayers players={evenTeam} />

          <hr />
          <h2>List of Indian Players Merged:</h2>
          <IndianPlayers players={IndianTeam} />
        </>
      )}
    </div>
  );
}

export default App;
