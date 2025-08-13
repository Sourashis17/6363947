import React, { useState } from 'react';
import GuestPage from './GuestPage';
import UserPage from './UserPage';
import LoginButton from './LoginButton';
import LogoutButton from './LogoutButton';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => {
    setIsLoggedIn(true);
  };

  const handleLogoutClick = () => {
    setIsLoggedIn(false);
  };

  let button;
  let page;

  if (isLoggedIn) {
    button = <LogoutButton onClick={handleLogoutClick} />;
    page = <UserPage />;
  } else {
    button = <LoginButton onClick={handleLoginClick} />;
    page = <GuestPage />;
  }

  return (
    <div style={{ padding: '20px' }}>
      <h1>Ticket Booking App</h1>
      {button}
      <hr />
      {page}
    </div>
  );
}

export default App;
