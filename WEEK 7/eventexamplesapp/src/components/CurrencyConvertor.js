import React, { useState } from 'react';

function CurrencyConvertor() {
  const [amount, setAmount] = useState('');
  const [converted, setConverted] = useState(null);

  const handleSubmit = (e) => {
    e.preventDefault(); // Synthetic Event prevents page reload
    const euro = (parseFloat(amount) / 88).toFixed(2); // assume 1 Euro = 88 INR
    setConverted(euro);
  };

  return (
    <div>
      <h2>Currency Convertor!!!</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Amount in INR: </label>
          <input
            type="number"
            value={amount}
            onChange={(e) => setAmount(e.target.value)} // Synthetic onChange
          />
        </div>
        <br />
        <button type="submit">Convert</button>
      </form>
      {converted && (
        <h3>
          Converted Amount in Euro: <span style={{ color: 'green' }}>€{converted}</span>
        </h3>
      )}
    </div>
  );
}

export default CurrencyConvertor;
