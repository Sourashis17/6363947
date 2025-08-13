import React from 'react';

function CourseDetails({ name, date }) {
  return (
    <div className="item">
      <p className="item-name">{name}</p>
      <p className="item-date">{date}</p>
    </div>
  );
}

export default CourseDetails;
