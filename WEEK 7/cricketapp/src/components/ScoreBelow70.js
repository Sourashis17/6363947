import React from "react";

function ScoreBelow70({ players }) {
  const players70 = players.filter((item) => item.score < 70);

  return (
    <div>
      {players70.map((item, index) => (
        <p key={index}>
          Mr. {item.name} <span>{item.score}</span>
        </p>
      ))}
    </div>
  );
}

export default ScoreBelow70;
