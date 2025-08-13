import React from "react";

// Step 1: Heading element
const heading = "Office Space";

// Step 2: Image JSX attribute
const officeImage = (
  <img
    src="https://via.placeholder.com/300x200.png?text=Office+Space"
    width="40%"
    height="40%"
    alt="Office Space"
  />
);

// Step 3: Single office object
const office = {
  Name: "DBS",
  Rent: 50000,
  Address: "Chennai",
};

// Step 4: Array of office spaces
const officeSpaces = [
  { Name: "DBS", Rent: 50000, Address: "Chennai" },
  { Name: "WeWork", Rent: 75000, Address: "Bangalore" },
  { Name: "Regus", Rent: 60000, Address: "Hyderabad" },
  { Name: "SmartWorks", Rent: 45000, Address: "Pune" },
];

// Step 5: Conditional rent color (inline CSS)
const getRentStyle = (rent) => {
  return {
    color: rent < 60000 ? "red" : "green",
    fontWeight: "bold",
  };
};

function App() {
  return (
    <div className="App" style={{ textAlign: "center", fontFamily: "Arial" }}>
      {/* Display heading */}
      <h1>{heading}, at Affordable Range</h1>

      {/* Display image */}
      {officeImage}

      <hr />

      {/* Display single office item */}
      <h2>Name: {office.Name}</h2>
      <h3 style={getRentStyle(office.Rent)}>Rent: Rs. {office.Rent}</h3>
      <h3>Address: {office.Address}</h3>

      <hr />
      <h2>More Office Spaces</h2>

      {/* Loop through office list */}
      {officeSpaces.map((item, index) => (
        <div key={index} style={{ marginBottom: "20px" }}>
          <h3>Name: {item.Name}</h3>
          <h4 style={getRentStyle(item.Rent)}>Rent: Rs. {item.Rent}</h4>
          <h4>Address: {item.Address}</h4>
        </div>
      ))}
    </div>
  );
}

export default App;
