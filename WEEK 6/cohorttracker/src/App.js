import React from 'react';
import './App.css';
import CohortDetails from './components/CohortDetails';

const App = () => {
  const cohorts = [
    {
      name: 'INTADMDF10 - NET FSD',
      startDate: '12-04-2022',
      status: 'Scheduled',
      coach: 'Aathma',
      trainer: 'Trainer'
    },
    {
      name: 'ADM21JF014 - Java FSD',
      startDate: '10-09-2001',
      status: 'Ongoing',
      coach: 'Disa Smith',
      trainer: 'Trainer'
    },
    {
      name: 'CDBJF21025 - Java FSB',
      startDate: '24-12-2020',
      status: 'Completed',
      coach: 'Nikhil',
      trainer: 'Trainer'
    }
  ];

  return (
    <div style={{ textAlign: 'center', padding: '20px' }}>
      <h1>Cohort Tracker</h1>
      {cohorts.map((cohort, index) => (
        <CohortDetails key={index} cohort={cohort} />
      ))}
    </div>
  );
};

export default App;
