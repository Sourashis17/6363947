import React from 'react';
import './App.css';
import Counter from './components/Counter';
import SayWelcome from './components/SayWelcome';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  return (
    <div className="App" style={{ textAlign: 'center' }}>
      <h1>React Event Handling Examples</h1>
      
      <hr />
      <Counter />

      <hr />
      <SayWelcome />

      <hr />
      <CurrencyConvertor />
    </div>
  );
}

export default App;
