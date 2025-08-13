import React from "react";

function EvenPlayers({ players }) {
  const [, second, , fourth, , sixth] = players;

  return (
    <div>
      <p>Second: {second}</p>
      <p>Fourth: {fourth}</p>
      <p>Sixth: {sixth}</p>
    </div>
  );
}

export default EvenPlayers;
