import React from 'react';

function SayWelcome() {
  const showWelcome = (message) => {
    alert(`Message: ${message}`);
  };

  return (
    <div>
      <h2>Say Welcome Example</h2>
      <button onClick={() => showWelcome('Welcome')}>Say Welcome</button>
    </div>
  );
}

export default SayWelcome;
