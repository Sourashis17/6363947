import React from "react";

function OddPlayers({ players }) {
  const [first, , third, , fifth] = players;

  return (
    <div>
      <p>First: {first}</p>
      <p>Third: {third}</p>
      <p>Fifth: {fifth}</p>
    </div>
  );
}

export default OddPlayers;
