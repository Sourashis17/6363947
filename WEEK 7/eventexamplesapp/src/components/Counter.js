import React, { Component } from 'react';

class Counter extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }

  // Single method to increment
  increment = () => {
    this.setState((prevState) => ({ count: prevState.count + 1 }));
  };

  sayHello = () => {
    alert("Hello! Have a great day!");
  };

  incrementAndGreet = () => {
    this.increment(); // calling another method
    this.sayHello();  // multiple methods
  };

  decrement = () => {
    this.setState((prevState) => ({ count: prevState.count - 1 }));
  };

  render() {
    return (
      <div>
        <h2>Counter: {this.state.count}</h2>
        <button onClick={this.incrementAndGreet}>Increase</button>
        <button onClick={this.decrement}>Decrease</button>
      </div>
    );
  }
}

export default Counter;
