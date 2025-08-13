import React from "react";

function ListOfPlayers({ players }) {
  return (
    <div>
      {players.map((item, index) => (
        <p key={index}>
          Mr. {item.name} <span>{item.score}</span>
        </p>
      ))}
    </div>
  );
}

export default ListOfPlayers;
