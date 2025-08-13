import React from 'react';

function BookDetails({ title, price }) {
  return (
    <div className="item">
      <p className="item-name">{title}</p>
      <p className="item-price">{price}</p>
    </div>
  );
}

export default BookDetails;
