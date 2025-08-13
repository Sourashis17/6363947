import React from "react";

function IndianPlayers({ players }) {
  return (
    <div>
      {players.map((player, index) => (
        <p key={index}>Mr. {player}</p>
      ))}
    </div>
  );
}

export default IndianPlayers;
